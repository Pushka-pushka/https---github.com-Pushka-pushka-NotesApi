using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MediatR;

namespace Notes.Aplication.Commands.DeleteNote
{
    public class DeleteNoteCommand : IRequest
    {
        public Guid UserId {get; set;}
        public Guid Id {get; set;}
    }
}