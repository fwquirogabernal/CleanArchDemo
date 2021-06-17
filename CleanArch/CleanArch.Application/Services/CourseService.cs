using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courceRepositor;
        private readonly IMediatorHandler _bus;

        public CourseService(ICourseRepository courceRepositor, IMediatorHandler bus)
        {
            _courceRepositor = courceRepositor;
            _bus = bus;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            var command = new CreateCourseCommand(courseViewModel.Name, courseViewModel.Description, courseViewModel.ImageUrl);
            _bus.SendCommand(command);
        }

        public CourseViewModel GetCources()
        {
            return new CourseViewModel { Courses = _courceRepositor.GetCourses() };
        }
    }
}
