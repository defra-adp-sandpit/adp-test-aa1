using Adp.Test.Aa1.Api.Models;
using Adp.Test.Aa1.Core.Entities;

using AutoMapper;

namespace Adp.Test.Aa1.Api.AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ItemRequest, Item>();
    }
}
