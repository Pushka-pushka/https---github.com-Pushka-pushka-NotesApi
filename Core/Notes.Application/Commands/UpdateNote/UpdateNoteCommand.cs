using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Notes.Application.Commands.UpdateNote
{
    public class UpdateNoteCommand : IRequest<Unit>
    {
        public Guid UserId {get; set;}
        public Guid Id {get; set;}
        public string Title {get; set;}
        public string NoteText {get; set;}
    }
}