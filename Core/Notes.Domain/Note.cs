using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes.Domain
{
    public class Note
    {
        public Guid UserId {get; set;}
        public Guid Id {get; set;}
        public string Title {get; set;}
        public string? NoteText {get; set;}
        public DateTime CreationDate {get; set;}
        public DateTime? EditDate{get; set;}
    }
}