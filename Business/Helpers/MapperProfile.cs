using AutoMapper;
using Data.Dtos;
using Data.Models;

namespace Business.Helper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<School, SchoolGetDto>()
                .ForMember(s => s.SchoolId, src => src.MapFrom(sg => sg.Id))
                .ForMember(s => s.SchoolName, src => src.MapFrom(sg => sg.Name))
                .ReverseMap();

            CreateMap<Student, StudentGetDto>()
                .ForMember(s => s.StudentId, src => src.MapFrom(sg => sg.Id))
                .ForMember(s => s.StudentNumber, src => src.MapFrom(sg => sg.Number))
                .ForMember(s => s.StudentName, src => src.MapFrom(sg => sg.Name))
                .ForMember(s => s.StudentSurname, src => src.MapFrom(sg => sg.Surname))
                .ReverseMap();

            //CreateMap(typeof(IEnumerable<>), typeof(IEnumerable<>));
        }
    }
}
