using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class BigViewModel
    {
        public GrillModel grill { get; set; }
        public ReservationViewModel reservation { get; set; }

    }


    public class ReservationViewModel
    {
        [DataType(DataType.Date)]
        [Required]
        public DateTime ReservationDate { get; set; }

        [Required]
        public string ReservatorName { get; set; }

        [Required]
        public string ReservationAddress { get; set; }

        [Phone]
        public int PhoneNum { get; set; }

        public string ReservationComment { get; set; }
    }
}
