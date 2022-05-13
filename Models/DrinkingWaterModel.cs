using System.ComponentModel.DataAnnotations;

namespace WaterDrinkingLogger.Models
{
    public class DrinkingWaterModel
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Range(0, Int32.MaxValue, ErrorMessage = "Value for {0} must be positibe.")]
        public int Quantity { get; set; }
    }
}
