using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;

namespace Notes.Aplication.Common.Mapping
{
    public interface IMapWith<T>
    {
        void Mapping(Profile profile)=>
            profile.CreateMap(typeof(T), GetType());
    }
}