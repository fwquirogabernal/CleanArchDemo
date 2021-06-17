using AutoMapper;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Models;

namespace CleanArch.Application.AutoMapper
{
    public class DomaintToViewModelProfile : Profile
    {
        public DomaintToViewModelProfile()
        {
            CreateMap<Course, CourseViewModel>();
        }
    }
}
