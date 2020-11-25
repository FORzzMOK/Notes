using Notes.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Notes.DAL
{
    public class MemoryStorage : IStorable
    {
        private static List<Note> Notes { get; set; }

        static MemoryStorage()
        {
            Notes = new List<Note>();
        }

        public bool AddNote(Note note)
        {
            if (Notes.Any(n => n.Id == note.Id))
                return false;

            Notes.Add(note);

            return true;
        }

        public ICollection<Note> GetAllNotes()
        {
            return Notes;
        }
    }
}
