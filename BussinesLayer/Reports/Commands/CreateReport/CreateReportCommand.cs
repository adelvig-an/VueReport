using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Reports.Commands.CreateReport
{
    public class CreateReportCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Number { get; set; }
    }
}
