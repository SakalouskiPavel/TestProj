using System;
using AutoMapper;
using TestProj.Common.DTO.Users;
using TestProj.Common.Enums;
using TestProj.Common.Models.DALModels.Users;

namespace TestProj.Common
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            this.CreateMap<RegisterUserDto, AccountDbModel>()
                .ForMember(item => item.Id, opt => opt.Ignore())
                .ForMember(item => item.CreatorId, opt => opt.Ignore())
                .ForMember(item => item.Id, opt => opt.Ignore())
                .ForMember(item => item.Email, opt => opt.MapFrom(item => item.Email))
                .ForMember(item => item.Password, opt => opt.MapFrom(item => item.Password))
                .ForMember(item => item.UserName, opt => opt.MapFrom(item => item.UserName))
                .ForMember(item => item.Permissions, opt => opt.UseValue(PermissionTypes.Base));
        }
    }
}