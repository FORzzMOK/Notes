using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.Entities
{
    public interface IStorable
    {
        bool AddNote(Note note);

        ICollection<Note> GetAllNotes();
    }
}
