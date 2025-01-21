using System.ComponentModel.DataAnnotations;

namespace PriceQuotation.Models
{
    public class Quotation
    {
        [Required(ErrorMessage = "Please enter a sale price.")]
        [Range(0, 100000000, ErrorMessage = "Sale price must be greater than zero.")]
        public double? Subtotal { get; set; }


        [Required(ErrorMessage = "Please enter a Province.")]
        public double? Province { get; set; }

        //[Required(ErrorMessage = "Please enter a discount percent.")]
        [Range(0, 100, ErrorMessage = "Discount percent must be between 0 and 100.")]



        public double? DiscountPercent { get; set; }


        public double CalculateDiscount() {
            if (Subtotal.HasValue && Province.HasValue)
            {
                return Subtotal.Value * (Province.Value / 100);  
            }
            else
            {
                return 0;
            }
        }

        public double CalculateTotal()
        {
            if (Subtotal.HasValue)
            {
                double discount = CalculateDiscount();
                return Subtotal.Value - discount;
            }
            else
            {
                return 0;
            }
        }
    }
}
