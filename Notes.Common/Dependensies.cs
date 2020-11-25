using Notes.DAL;
using Notes.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.Common
{
    public static class Dependensies
    {
        public static IStorable NotesStorage { get; } = new MemoryStorage();
    }
}
