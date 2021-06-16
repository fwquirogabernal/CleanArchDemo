using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courceRepositor;

        public CourseService(ICourseRepository courceRepositor)
        {
            _courceRepositor = courceRepositor;
        }

        public CourceViewModel GetCources()
        {
            return new CourceViewModel { Courses = _courceRepositor.GetCourses() };
        }
    }
}
