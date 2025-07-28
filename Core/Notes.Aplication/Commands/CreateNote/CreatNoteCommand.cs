using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Notes.Aplication.Commands.CreateNote
{
    public class CreatNoteCommand : IRequest <Guid>
    {
        public Guid UserId{get; set;}
        public string Title {get; set;}
        public string NoteText {get; set;}
        
    }
}