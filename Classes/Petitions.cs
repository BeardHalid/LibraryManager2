using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Classes
{
    [FirestoreData]
    public class Petitions
    {
        [FirestoreDocumentId]
        public string? docId { get; set; }
        [FirestoreProperty(name: "petition")]
        public string? Petition { get; set; }
        [FirestoreProperty(name: "petition_type")]
        public string? PetitionType { get; set; }
        [FirestoreProperty(name: "sender")]
        public string? Sender { get; set; }
        [FirestoreProperty(name: "status")]
        public string? Status { get; set; }
        [FirestoreProperty(name: "device_token")]
        public string? DeviceToken { get; set; }
    }
}
