using AutoMapper;
using BussinesLayer.Common.Mappings;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Reports.Queries.GetReportDetails
{
    public class ReportDetailsVM : IMapWith<Report>
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime CreationDate { get; set; }

        public void Mapping (Profile profile)
        {
            profile.CreateMap<Report, ReportDetailsVM>()
                .ForMember(reportVM => reportVM.Number,
                opt => opt.MapFrom(report => report.Number))
                .ForMember(reportVM => reportVM.Id,
                opt => opt.MapFrom(report => report.Id))
                .ForMember(reportVM => reportVM.CreationDate,
                opt => opt.MapFrom(report => report.CreationDate));
        }
    }
}
