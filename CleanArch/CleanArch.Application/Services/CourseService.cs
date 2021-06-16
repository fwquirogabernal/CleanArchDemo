using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courceRepositor;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository courceRepositor, IMediatorHandler bus, IMapper mapper)
        {
            _courceRepositor = courceRepositor;
            _bus = bus;
            _mapper = mapper;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            _bus.SendCommand(_mapper.Map<CreateCourseCommand>(courseViewModel));
        }

        public IEnumerable<CourseViewModel> GetCources()
        {
            return  _courceRepositor.GetCourses().ProjectTo<CourseViewModel>(_mapper.ConfigurationProvider);
        }
    }
}
