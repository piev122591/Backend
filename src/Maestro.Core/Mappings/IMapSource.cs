using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Core.Mappings
{
    public interface IMapSource<T> where T : class
    {
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}
