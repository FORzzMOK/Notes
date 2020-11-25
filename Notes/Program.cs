using Notes.BLL;
using Notes.Entities;
using System;
using System.Collections.Generic;

namespace Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            SelectOptionByUser();
        }

        private static void SelectOptionByUser()
        {
            while(true)
            {
                Console.WriteLine("Plase select some action: ");
                Console.WriteLine("1. Add Note ");
                Console.WriteLine("2. Show Notes ");
                Console.WriteLine("3. Exit");

                var input = Console.ReadLine();

                if (uint.TryParse(input, out uint selectedOption)
                    && selectedOption > 0
                    && selectedOption < 4)
                {
                    switch (selectedOption)
                    {
                        case 1:
                            NotesManager.AddNote(Console.ReadLine(), DateTime.Now);
                            break;
                        case 2:
                            ShowNotes(NotesManager.GetAllNotes());
                            break;
                        case 3:
                            return;
                    }
                }
            }
        }

        private static void ShowNotes(IEnumerable<Note> notes)
        {
            foreach (var item in notes)
            {
                Console.WriteLine($"{item.Id} --- {item.Text} --- {item.CreationTime}");
            }
        }
    }
}
