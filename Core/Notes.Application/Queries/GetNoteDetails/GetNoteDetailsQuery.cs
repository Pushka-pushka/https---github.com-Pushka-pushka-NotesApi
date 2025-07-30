using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Notes.Application.Queries.GetNoteDetails
{
    public class GetNoteDetailsQuery: IRequest<NoteDetailsVm>
    {
        public Guid UserId{get; set;}
        public Guid Id {get; set;}
    }
}