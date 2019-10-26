using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tracking.Data.Models;
using TrackingMyFoodAPI.Models.Requests;

namespace TrackingMyFoodAPI.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Company, AddNewCompanyRequest>();
        }
    }
}
