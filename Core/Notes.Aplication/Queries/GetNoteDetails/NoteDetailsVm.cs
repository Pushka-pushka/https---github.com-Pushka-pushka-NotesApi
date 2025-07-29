using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

using Notes.Aplication.Common.Mapping;
using Notes.Domain;

namespace Notes.Aplication.Queries.GetNoteDetails
{
    public class NoteDetailsVm: IMapWith<Note>
    {
        public Guid Id {get; set;}
        public string Title {get; set;}
        public string? NoteText {get; set;}
        public DateTime CreationDate {get; set;}
        public DateTime? EditDate {get; set;} 

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Note, NoteDetailsVm>()
                .ForMember(noteVm => noteVm.Title,
                    opt => opt.MapFrom(note => note.Title))
                .ForMember(noteVm => noteVm.NoteText,
                    opt => opt.MapFrom(note => note.NoteText))
                .ForMember(noteVm => noteVm.Id,
                    opt => opt.MapFrom(note => note.Id))
                .ForMember(noteVm => noteVm.CreationDate,
                    opt => opt.MapFrom(note => note.CreationDate))
                .ForMember(noteVm => noteVm.EditDate,
                    opt => opt.MapFrom(note => note.EditDate));


        }

    }
}