using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MediatR;

namespace Notes.Application.Queries.GetNoteList
{
    public class GetNoteListQuery : IRequest<NoteListVm>
    {
        public Guid UserId{get; set;}
        
    }
}