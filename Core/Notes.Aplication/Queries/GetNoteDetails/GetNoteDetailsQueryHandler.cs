using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameWorkCore;
using MediatR;
using AutoMapper;

using Notes.Aplication.interfaces;
using Notes.Aplication.Common.Exceptions;
using Notes.Domain;


namespace Notes.Aplication.Queries.GetNoteDetails
{
    public class GetNoteDetailsQueryHandler: IRequestHandler<GetNoteDetailsQuery, NoteDetailsVm>
    {

        private readonly INotesDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetNoteDetailsQueryHandler(INotesDbContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }
        public async Task<NoteDetailsVm> Handle(GetNoteDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Notes
                .FirstOrDefaultAsync(
                    note => note.Id == request.Id, cancellationToken);
             
            if(entity == null || entity.UserId != request.UserId)
             {
                throw new NotFoundExctption(nameof(Note), request.Id);
             }

             return _mapper.Map<NoteDetailsVm>(entity);

        }
    }
}