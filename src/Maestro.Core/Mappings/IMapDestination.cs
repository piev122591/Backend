using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Core.Mappings
{
    public interface IMapDestination<T> where T : class
    {
        void Mapping(Profile profile) => profile.CreateMap(GetType(), typeof(T));
    }
}
