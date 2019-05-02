using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class GrillModel
    {
        [Key]
        public int GrillId { get; set; }
        [Required]
        public string GrillType { get; set; }
        public string GrillDecription { get; set; }
        [Required]
        public int GrillPricePerHour { get; set; }

      
        
       // public int? ReservationId { get; set; }
        public List<GrillReservation> ReservGrills { get; set; }

    }
}
