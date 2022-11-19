using Model.Customer;
using Model.RealEstate;

namespace Model
{
    public class EvaTask
    {
        public int Id { get; set; }
        public ICollection<RealEstateObject> RealEstateObjects { get; set; } = null!;
        public EnumTarget TargetType { get; set; }
        public string CostPrerequisites { get; set; } = null!;
        public string IntendedUse { get; set; } = null!;
        public EnumCustomer CustomerType { get; set; }
        public PrivatePerson PrivatePerson { get; set; } = null!;
        public Organization Organization { get; set; } = null!;
    }
}
