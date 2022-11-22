using AutoMapper;
using BussinesLayer.Common.Mappings;
using BussinesLayer.Reports.Commands.UpdateReport;

namespace VueReportBackend.Models
{
    public class UpdateReportDto : IMapWith<UpdateReportCommand>
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateReportDto, UpdateReportCommand>()
                .ForMember(reportCommand => reportCommand.Id,
                    opt => opt.MapFrom(reportDto => reportDto.Id))
                .ForMember(reportCommand => reportCommand.Number,
                    opt => opt.MapFrom(reportDto => reportDto.Number));
        }
    }
}
