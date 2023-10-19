using AutoMapper;
using DevManager.Domain.Entities;
using DevManager.Repositories;
using DevManager.ViewModels;

namespace DevManager.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Assignment, AssignmentVM>();
            CreateMap<AssignmentVM, Assignment>();
            CreateMap<Customer, CustomerVM>();
            CreateMap<CustomerVM, Customer>();
            CreateMap<Project, ProjectVM>();
            CreateMap<ProjectVM, Project>();
            CreateMap<Team, TeamVM>();
            CreateMap<TeamVM, Team>();
            CreateMap<AspNetUser, UserVM>();
            CreateMap<UserVM, AspNetUser>();
        }
    }
}
