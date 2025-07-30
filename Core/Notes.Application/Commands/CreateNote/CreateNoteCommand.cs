using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Notes.Application.Commands.CreateNote
{
    public class CreateNoteCommand : IRequest <Guid>
    {
        public Guid UserId{get; set;}
        public string Title {get; set;}
        public string NoteText {get; set;}
        
    }
}