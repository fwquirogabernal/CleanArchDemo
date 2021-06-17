using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanArch.Infra.Data.Repositories
{
    public class CourceRepository : ICourseRepository
    {
        private readonly UniversityDBContext _context;

        public CourceRepository(UniversityDBContext context)
        {
            _context = context;
        }

        public void Add(Course course)
        {
            _context.Add(course);
            _context.SaveChanges();
        }

        public IEnumerable<Course> GetCourses()
        {
            try
            {
                return _context.Courses.ToArray();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
