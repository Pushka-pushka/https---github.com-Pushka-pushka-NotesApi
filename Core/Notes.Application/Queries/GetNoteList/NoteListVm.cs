using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes.Application.Queries.GetNoteList
{
    public class NoteListVm
    {
        public IList<NoteLookupDto> Notes {get; set;}
    }
}