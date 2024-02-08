using LibraryManager.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Repository
{
    public interface IBase
    {
        public Task<List<Petitions>> GetPetitions();
        public void UpdatePetition(string docId);
    }
}
