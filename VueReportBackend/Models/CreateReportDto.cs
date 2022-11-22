using AutoMapper;
using BussinesLayer.Common.Mappings;
using BussinesLayer.Reports.Commands.CreateReport;

namespace VueReportBackend.Models
{
    public class CreateReportDto : IMapWith<CreateReportCommand>
    {
        public string Number { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateReportDto, CreateReportCommand>()
                .ForMember(reportCommand => reportCommand.Number,
                    opt => opt.MapFrom(reportDto => reportDto.Number));
        }
    }
}
