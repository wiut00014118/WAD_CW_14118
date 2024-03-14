using System.ComponentModel.DataAnnotations;

namespace WAD_14118.Models
{
    public enum Genre
    {
        Drama,
        Comedy,
        Romance,
        [Display(Name = "Romantic Comedy")]
        RomCom,
        Crime,
        Mystery
    }
}