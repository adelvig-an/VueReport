namespace Model.RealEstate
{
    public class RealEstateObject
    {
        public int Id { get; set; }
        public EnumRealEstate RealEstateType { get; set; }
        public EnumResidentialRealEstate ResidentialRealEstateType { get; set; }
        public EnumResidentialPremises ResidentialPremisesType { get; set; }
        public Address Address { get; set; } = null!;
        public EnumFormOwnership FormOwnershipType { get; set; }
    }
}
