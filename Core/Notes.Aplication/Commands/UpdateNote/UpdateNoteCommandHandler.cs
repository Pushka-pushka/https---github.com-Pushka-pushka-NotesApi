using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


using Microsoft.EntityFrameworkCore;

using MediatR;

using Notes.Aplication.Common.Exceptions;
using Notes.Aplication.Interfaces;
using Notes.Domain;

namespace Notes.Aplication.Commands.UpdateNote
{
    public class UpdateNoteCommandHandler: IRequestHandler<UpdateNoteCommand, Unit>

    {
        private readonly INotesDbContext _dbContext;

        public UpdateNoteCommandHandler(INotesDbContext dbContext)=>
            _dbContext = dbContext;



        public async Task<Unit> Handle(UpdateNoteCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Notes.FirstOrDefaultAsync(
                note => note.Id ==request.Id, cancellationToken);

            if(entity == null || entity.UserId != request.UserId)
            {
                throw new NotFoundException(nameof(Note), request.Id);

            }

            entity.Title = request.Title;
            entity.NoteText = request.NoteText;
            entity.EditDate = DateTime.Now;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;

        }
    }
        
}
