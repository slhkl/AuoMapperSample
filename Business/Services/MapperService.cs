using AutoMapper;
using Data.Dtos;
using Data.Models;
using System.Diagnostics;

namespace Business.Services
{
    public class MapperService
    {
        private IMapper _mapper;

        public MapperService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public object DirectMap(List<Student> studentList)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            var students = _mapper.Map<IEnumerable<StudentGetDto>>(studentList).ToList();

            stopwatch.Stop();

            return new
            {
                stopwatch.ElapsedMilliseconds,
                students
            };
        }

        public object SelectMap(List<Student> studentList)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            var students = studentList.Select(_mapper.Map<StudentGetDto>).ToList();

            stopwatch.Stop();

            return new
            {
                stopwatch.ElapsedMilliseconds,
                students
            };
        }
    }
}
