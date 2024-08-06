using System.ComponentModel.DataAnnotations;

namespace RetroVideoStore.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        [EmailAddress]
        public string CustomerEmail { get; set; }
        [Required]
        public Rental[] Rentals { get; set; }
        public double TotalCost
        { 
            get 
            { 
                return TotalCost; 
            } 
            set 
            {
                TotalCost = 0;
                foreach (Rental rental in Rentals) 
                {
                    TotalCost += rental.Cost;
                } 
            } 
        }
    }
}
