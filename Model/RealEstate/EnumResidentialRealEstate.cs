using System.ComponentModel.DataAnnotations;

namespace Model.RealEstate
{
    public enum EnumResidentialRealEstate
    {
        [Display(Name = "Жилое помещение")]
        ResidentialPremises = 0,
        [Display(Name = "Жилой дом")]
        ResidentialBuilding = 1,
    }
}
