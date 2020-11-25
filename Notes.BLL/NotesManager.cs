using Notes.Common;
using Notes.DAL;
using Notes.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.BLL
{
    public static class NotesManager
    {
        public static void AddNote(string text, DateTime creationTime)
        {
            Dependensies.NotesStorage.AddNote(new Note(text){ CreationTime = creationTime });
        }
        public static void AddNote(Note note)
        {
            note.CreationTime = DateTime.Now;

            Dependensies.NotesStorage.AddNote(note);
        }

        public static IEnumerable<Note> GetAllNotes()
        {
            return Dependensies.NotesStorage.GetAllNotes();
        }
    }
}
