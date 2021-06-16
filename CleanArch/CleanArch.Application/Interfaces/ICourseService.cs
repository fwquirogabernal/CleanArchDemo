using CleanArch.Application.ViewModels;
using System.Collections.Generic;

namespace CleanArch.Application.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCources();
        void Create(CourseViewModel courseViewModel);
    }
}
