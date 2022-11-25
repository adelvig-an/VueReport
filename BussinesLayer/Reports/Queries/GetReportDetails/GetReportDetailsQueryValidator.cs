using FluentValidation;

namespace BussinesLayer.Reports.Queries.GetReportDetails
{
    internal class GetReportDetailsQueryValidator : AbstractValidator<GetReportDetailsQuery>
    {
        public GetReportDetailsQueryValidator() 
        {
            RuleFor(report => report.UserId).NotEmpty();
            RuleFor(report => report.Id).NotEmpty();
        }
    }
}
