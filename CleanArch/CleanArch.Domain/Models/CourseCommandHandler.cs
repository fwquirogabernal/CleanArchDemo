using CleanArch.Domain.Commands;
using CleanArch.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArch.Domain.Models
{
    public class CourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>
    {
        private readonly ICourseRepository _repository;

        public CourseCommandHandler(ICourseRepository repository)
        {
            _repository = repository;
        }

        public Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var course = new Course
                {
                    Name = request.Name,
                    Description = request.Description,
                    ImageUrl = request.ImageUrl
                };

                _repository.Add(course);
                return Task.FromResult(true);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
