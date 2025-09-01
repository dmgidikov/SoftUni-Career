using System.ComponentModel.DataAnnotations;

namespace FinanceApp.Models
{
    public class Expense
    {
        private const string INVALID_AMOUNT = "The amount needs to be highter than 0";

        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = INVALID_AMOUNT)]
        public double Amount { get; set; }

        [Required]
        public string Category { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}