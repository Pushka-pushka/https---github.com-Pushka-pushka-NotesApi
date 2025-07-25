using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Core.Notes.Domain;

namespace Notes.Aplication.Interfaces
{
    public interface INotesDbContext
    {
        DbSet<Note> Notes {get; set;}
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}