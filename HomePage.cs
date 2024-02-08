using FirebaseAdmin;
using LibraryManager.Classes;
using LibraryManager.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class HomePage : Form
    {
        private Base b;
        private List<Petitions> list;
        public HomePage()
        {
            InitializeComponent();
            b = new();
            list = new List<Petitions>();
            GetPets();
        }

        private void GetPets()
        {
            Task.Run(() => { list = b.GetPetitions().Result; }).Wait();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Dilekçe Id", typeof(string));
            dt.Columns.Add("Gönderen", typeof(string));
            dt.Columns.Add("Gönderi Türü", typeof(string));

            foreach (Petitions item in list)
            {
                dt.Rows.Add(new object[] { item.docId!, item.Sender!, item.PetitionType! });
            }
            dgvPetitions.DataSource = dt;

        }

        private void btnUnselectAll_Click(object sender, EventArgs e)
        {
            dgvPetitions.ClearSelection();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            dgvPetitions.SelectAll();
        }

        private void btnMarkAll_Click(object sender, EventArgs e)
        {
            var rows = dgvPetitions.Rows;
            foreach (DataGridViewRow item in rows)
            {
                if (item.Selected)
                {
                    b.UpdatePetition(item.Cells[0].Value.ToString()!);
                }
            }
        }
    }
}
