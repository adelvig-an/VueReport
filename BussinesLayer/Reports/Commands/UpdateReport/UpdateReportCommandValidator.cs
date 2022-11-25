using FluentValidation;

namespace BussinesLayer.Reports.Commands.UpdateReport
{
    internal class UpdateReportCommandValidator : AbstractValidator<UpdateReportCommand>
    {
        public UpdateReportCommandValidator()
        {
            RuleFor(updateReportCommand =>
                updateReportCommand.UserId).NotEmpty();
            RuleFor(updateReportCommand => 
                updateReportCommand.Id).NotEmpty();
            RuleFor(updateReportCommand =>
                updateReportCommand.Number).NotEmpty().MaximumLength(10);
        }
    }
}
