using System.ComponentModel.DataAnnotations;

namespace Model
{
    public enum EnumFormOwnership
    {
        [Display(Name = "Право собственности")]
        Ownership = 0,
        [Display(Name = "Право аренды")]
        Rent = 1,
        [Display(Name = "Право требования")]
        LegalClaim = 2,
    }
}
