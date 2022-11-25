using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Reports.Commands.DeleteReport
{
    public class DeleteReportCommand : IRequest
    {
        public int UserId { get; set; }
        public int Id { get; set; }
    }
}
