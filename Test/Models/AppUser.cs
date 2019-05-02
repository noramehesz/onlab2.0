using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class AppUser : IdentityUser
    {
      //  [Key]
      //  public int UserId { get; set; }

       // [ForeignKey("ReservationModel")]
        //public int Reservation_Id { get; set; }
        public List<ReservationModel> ReservationsOfUsers { get; set; }
    }
}
