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
    public class DeleteNoteCommanndHandler : IRequestHandler<DeleteNoteCommand>
    {
        private readonly INotesDbContext _dbContext;

        public DeleteNoteCommand(INotesDbContext context) =>
            _Context=context;

        public async Task<Unit> Handle(DeleteNoteCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Notes
                .FindAsync(new object[] {request.Id}, cancellationToken);
            
            if(entity == null || entity.UserId != request.UserId)
            {
                throw new NotFoundException(nameof(Note, request.Id));
            }

            _dbContext.Notes.Remove(entity);
            await _dbContext.SaveChangesAsync(CancellationToken);

            return Unit.Value;
        }
    }
}