using System.ComponentModel.DataAnnotations;

namespace Model
{
    public enum EnumTarget
    {
        [Display(Name = "Рыночная стоимость")]
        MarketValue = 0,
        [Display(Name = "Рыночная и ликвидационная стоимость")]
        MarketAndLiquidationValue = 1,
        [Display(Name = "Ликвидационная стоимость")]
        LiquidationValue = 2,
        [Display(Name = "Инвестиционная стоимость")]
        InvestmentValue = 3
    }
}
