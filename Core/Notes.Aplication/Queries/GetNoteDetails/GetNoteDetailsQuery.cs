using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Notes.Aplication.Queries.GetNoteDetails
{
    public class GetNoteDetailsQuery: IRequest<NoteDetailVm>
    {
        public Guid UserId{get; set;}
        public Guid Id {get; set;}
    }
}