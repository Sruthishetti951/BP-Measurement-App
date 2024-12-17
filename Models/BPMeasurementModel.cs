using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPMeasurmentApp.Models
{
    public class BPMeasurementModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? ID {get; set; }


        [Required(ErrorMessage ="Please enter systoic reading")]
        [Range(20,400, ErrorMessage ="Reading must be between 20 and 400")]
        public int? Systolic { get; set; }

        [Required(ErrorMessage = "Please enter diastolic reading")]
        [Range(10, 300, ErrorMessage = "Reading must be between 10 and 300")]
        public int? Diastolic { get; set; }

        public string[]? Category { get
            {
                if(Systolic<120 && Diastolic < 80)
                {
                    return ["Normal","green"];
                }else if((Systolic>=120 && Systolic<=129) && Diastolic < 80)
                {
                    return ["Elevated","yellow"];
                }
                else if ((Systolic >= 130 && Systolic <= 139) || (Diastolic >=80 && Diastolic<=89))
                {
                    return ["Hypertension Stage 1","orange"];
                }
                else if ((Systolic >= 140 && Systolic <= 180) || (Diastolic >= 90 && Diastolic <= 120))
                {
                    return ["Hypertension Stage 2","orangered"];
                }
                else if (Systolic > 180 || Diastolic > 120)
                {
                    return ["Hypertensive Crisis","darkred"];
                } 
                return null;
            }
        }

        [Required(ErrorMessage = "Please enter the reading date")]
        [DataType(DataType.Date)]
        public DateTime? DateTaken  { get; set; }

        [Required(ErrorMessage = "Please enter position while giving the reading")]
        public int? PositionID {  get; set; }

    }
}
