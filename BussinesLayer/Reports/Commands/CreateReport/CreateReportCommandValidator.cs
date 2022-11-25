using FluentValidation;

namespace BussinesLayer.Reports.Commands.CreateReport
{
    public class CreateReportCommandValidator : AbstractValidator<CreateReportCommand>
    {
        public CreateReportCommandValidator()
        {
            RuleFor(createReportCommand =>
                createReportCommand.Number).NotEmpty().MaximumLength(10);
            RuleFor(createReportCommand =>
                createReportCommand.UserId).NotEmpty();
        }
    }
}
