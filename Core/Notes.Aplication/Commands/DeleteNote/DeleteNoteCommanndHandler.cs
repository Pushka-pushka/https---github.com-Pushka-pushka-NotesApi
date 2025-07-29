using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

using Notes.Domain;
using Notes.Aplication.Interfaces;
using Notes.Aplication.Common.Exceptions;

namespace Notes.Aplication.Commands.DeleteNote
{
    public class DeleteNoteCommanndHandler : IRequestHandler<DeleteNoteCommand, Unit>
    {
        private readonly INotesDbContext _dbContext;

        public DeleteNoteCommanndHandler(INotesDbContext context) =>
            _dbContext = context;



        public async Task<Unit> Handle(DeleteNoteCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Notes
                .FindAsync(new object[] {request.Id}, cancellationToken);
            

            if(entity == null || entity.UserId != request.UserId)
            {
                throw new NotFoundException(nameof(Note), request.Id);   // nameof(Note)
            }

            _dbContext.Notes.Remove(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }


    }
}