using System.ComponentModel.DataAnnotations;

namespace BackEndVGDelen.Models
{
    public class Pizza
    {
        [Key]
        public int PizzaID { get; set; }
        public string PizzaName { get; set; }
        public List<PizzaIngredient> PizzaIngredients { get; set; }

    }
}