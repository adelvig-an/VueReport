using AutoMapper;
using BussinesLayer.Common.Mappings;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Reports.Queries.GetReportList
{
    public class ReportLookupDto : IMapWith<Report>
    {
        public Guid Id { get; set; }
        public string Number { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Report, ReportLookupDto>()
                .ForMember(reportDto => reportDto.Id,
                opt => opt.MapFrom(report => report.Id))
                .ForMember(reportDto => reportDto.Number,
                opt => opt.MapFrom(report => report.Number));
        }
    }
}
