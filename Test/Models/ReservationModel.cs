using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Test.Models
{
    public class ReservationModel
    {
        [Key]
        public int ReservationId { get; set; }

        public List<GrillReservation> ReservGrills { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime ReservationDate { get; set; }
        [Required]
        public string ReservatorName { get; set; }

        [Display(Name = "Address")]
        [Required]
        public string ReservationAddress { get; set; }

        [Display(Name = "Phone number")]
        public int PhoneNum { get; set; }

        [Display(Name = "Comment")]
        public string ReservationComment { get; set; }

        //[ForeignKey("AppUser")]
        public string UserId { get; set; }
        public AppUser User { get; set; }

       

        // kell meg egy olyan, hogy melyik user-hez tartozik a reservation
    }
}
