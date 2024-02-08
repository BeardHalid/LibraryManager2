using FirebaseAdmin;
using FirebaseAdmin.Messaging;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;
using LibraryManager.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Message = FirebaseAdmin.Messaging.Message;

namespace LibraryManager.Repository
{
    public class Base : IBase
    {
        private FirestoreDb firestoreDb;
        public Base() {
            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "libraryapp-36a24-firebase-adminsdk-5ndav-77bd750252.json")),
            });

            var filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "libraryapp-36a24-firebase-adminsdk-5ndav-77bd750252.json");
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
            firestoreDb = FirestoreDb.Create("libraryapp-36a24");
        }
        public async Task<List<Petitions>> GetPetitions()
        {
            var list = await firestoreDb.Collection("petitions").GetSnapshotAsync();
            return list.Documents.Select(pet => pet.ConvertTo<Petitions>()).ToList();  
        }

        public async void UpdatePetition(string docId)
        {
            var docPet = await firestoreDb.Collection("petitions").Document(docId).GetSnapshotAsync();
            var pet = docPet.ConvertTo<Petitions>();
            var d = new Dictionary<string, dynamic>
            {
                ["device_token"] = pet.DeviceToken!,
                ["sender"] = pet.Sender!,
                ["status"] = "Okunmuş",
                ["petition"] = pet.Petition!,
                ["petition_type"] = pet.PetitionType!
            };
            var rs = await firestoreDb.Collection("petitions").Document(docId).UpdateAsync(d);
            Debug.WriteLine(rs);

            string token = pet.DeviceToken!;
            var msg = new Message()
            {
                Notification = new Notification()
                {
                    Title = "Dilekçe",
                    Body = "Dilekçeniz görüntülendi"
                },
                Data = new Dictionary<string, string> { 
                    { "result", "ok" } 
                },
                Token = token
            };
            string response = await FirebaseMessaging.DefaultInstance.SendAsync(msg);
            Debug.WriteLine("Successfully sent message : " + response);
        }
    }
}
