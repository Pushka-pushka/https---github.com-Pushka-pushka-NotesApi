using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Notes.Aplication.Interfaces;
using Notes.Domain;
using Notes.Persistence.EntityTypeConfigurations;

namespace Notes.Persistence
{
    public class NotesDbContext: DbContext, INotesDbContext
    {
        public DvSet<Note> Notes {get; set;}
        public NotesDbContext(DbContextOptions<NotesDbContext> options)
            : base(options) {}
        
        protected override void OnModelCreating(ModelBuiler builder)
        {
            builder.ApplyConfiguration(now NoteConfiguration());
            base.OnModelCreating(builder);
        }
        
    }
}