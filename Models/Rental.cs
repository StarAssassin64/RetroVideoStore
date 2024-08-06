using System.ComponentModel.DataAnnotations;

namespace RetroVideoStore.Models
{
    public class Rental
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string? Description { get; set; }
        [Required]
        public string Format { get; set; }
        public double Cost
        {
            get 
            {
                return Cost;
            }
            set
            {
                if (Format == "VHS")
                { 
                    Cost = 3.99; 
                }
                else if (Format == "DVD") 
                { 
                    Cost = 4.99; 
                }
            }
        }
    }
}
