using DoAnPBL3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.DAL
{
    class DAL_QLGC
    {
        private static DAL_QLGC _Instance;
        public static DAL_QLGC Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLGC();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private DAL_QLGC()
        {

        }

        public List<Note> GetAllNoteByAccountUsername(string accountUsername)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Note> notes = db.Notes
                    .Where(note => note.AccountUsername == accountUsername)
                    .ToList();
                if (notes.Count > 0)
                    return notes;
                else
                    return null;
            }
        }

        public bool AddNewNote(Note note)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                db.Notes.Add(note);
                int result = db.SaveChanges();
                return result > 0;
            }
        }
    }
}
