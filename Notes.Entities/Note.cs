using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.Entities
{
    public class Note
    {
        public Guid Id { get; private set; }

        public string Text { get; private set; }

        public DateTime CreationTime { get; set; }

        public void ChangeText(string newText)
        {
            Text = newText;
        }

        public Note(string content)
        {
            Id = Guid.NewGuid();

            Text = content;
        }
    }
}
