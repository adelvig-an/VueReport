using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Reports.Queries.GetReportList
{
    public class GetReportListQuery : IRequest<ReportListVM>
    {
        public Guid UserId { get; set; }
    }
}
