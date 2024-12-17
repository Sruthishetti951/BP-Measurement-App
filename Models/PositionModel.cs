using System.ComponentModel.DataAnnotations;

namespace BPMeasurmentApp.Models
{
    public class Position
    {
        [Key]
        public int? PositionID { get; set; }
        public string? PositionName { get; set; }
    }
}