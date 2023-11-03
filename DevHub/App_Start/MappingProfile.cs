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
            Mapper.CreateMap<SkillsModel, SkillsDto>().ReverseMap();
            Mapper.CreateMap<CountryDto, CountryModel>().ReverseMap();
            Mapper.CreateMap<StateDto, StateModel>().ReverseMap();
            Mapper.CreateMap<CityDto, CityModel>().ReverseMap();
            Mapper.CreateMap<CandidateDto, CandidateModel>().ReverseMap();
            Mapper.CreateMap<CompanyDto, CompanyModel>().ReverseMap();
            Mapper.CreateMap<JobModeDto, JobModeModel>().ReverseMap();
            Mapper.CreateMap<JobTypeDto, JobTypeModel>().ReverseMap();
            Mapper.CreateMap<JobCategoryDto, JobCategoryModel>().ReverseMap();
            Mapper.CreateMap<JobDto, JobModel>().ReverseMap();
            Mapper.CreateMap<CompanyJobDto, CompanyJobMapper>().ReverseMap();
            Mapper.CreateMap<CandidateJobDto, CandidateJobMapper>().ReverseMap();
        }
    }
}