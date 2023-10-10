using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using DevHub.Models;
using DevHub.Dtos;

namespace DevHub.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<SkillsModel, SkillsDto>();
            Mapper.CreateMap<SkillsDto, SkillsModel>();
            Mapper.CreateMap<CountryDto, CountryModel>().ReverseMap();
            Mapper.CreateMap<StateDto, StateModel>().ReverseMap();
            Mapper.CreateMap<CityDto, CityModel>().ReverseMap();
            Mapper.CreateMap<CandidateDto, CandidateModel>().ReverseMap();
        }
    }
}