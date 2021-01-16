using AutoMapper;
using MoviesRental.Dtos;
using MoviesRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesRental.App_Start
{
    public class MappingProfile : Profile 
    { 
        public MappingProfile() 
        {
            // Domain to Dto
            CreateMap<Customer, CustomerDto>();
            CreateMap<Movie, MovieDto>();
            CreateMap<MembershipType, MembershipTypeDto>();

            // Dto to Domain
            CreateMap<CustomerDto, Customer>();
            CreateMap<MovieDto, Movie>();         

        } 
    }
}