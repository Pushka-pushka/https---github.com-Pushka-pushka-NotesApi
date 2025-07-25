using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Notes.Domain;


namespace Notes.Persistence.EntityTypeConfigurations
{
    public class NoteConfiguration: IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasKey(note => note.Id);
            builder.HasIndex(note => noteId).IsUnique();
            builder.Property(note => note.Title).HasMaxLength(100);
            builder.Property(note => note.NoteText).HasMaxLength(300);
        }
        
    }
}