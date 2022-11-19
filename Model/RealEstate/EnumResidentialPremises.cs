using System.ComponentModel.DataAnnotations;

namespace Model.RealEstate
{
    public enum EnumResidentialPremises
    {
        [Display(Name = "Квартира")]
        Flat = 0,
        [Display(Name = "Апартаменты")]
        Apartment = 1,
        [Display(Name = "Доля (комната)")]
        PartFlat = 2,
    }
}
