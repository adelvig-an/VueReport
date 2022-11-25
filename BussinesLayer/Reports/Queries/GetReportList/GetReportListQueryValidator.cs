using FluentValidation;

namespace BussinesLayer.Reports.Queries.GetReportList
{
    internal class GetReportListQueryValidator : AbstractValidator<GetReportListQuery>
    {
        public GetReportListQueryValidator() 
        {
            RuleFor(x => x.UserId).NotEmpty();
        }
    }
}
