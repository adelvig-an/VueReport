using System.ComponentModel.DataAnnotations;

namespace Model.RealEstate
{
    public enum EnumRealEstate
    {
        [Display(Name = "Жилая недвижимлсть")]
        ResidentialRealEstate = 0,
        [Display(Name = "Нежилая недвижимость")]
        NonResidentialRealEstate = 1,
    }
}
