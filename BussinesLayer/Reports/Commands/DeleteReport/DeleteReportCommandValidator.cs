
using FluentValidation;

namespace BussinesLayer.Reports.Commands.DeleteReport
{
    internal class DeleteReportCommandValidator : AbstractValidator<DeleteReportCommand>
    {
        public DeleteReportCommandValidator()
        {
            RuleFor(deleteReportCommand =>
                deleteReportCommand.UserId).NotEmpty();
            RuleFor(deleteReportCommand =>
                deleteReportCommand.Id).NotEmpty();
        }
    }
}
