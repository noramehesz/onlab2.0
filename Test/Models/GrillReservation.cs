using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class GrillReservation
    {
        public int Id { get; set; }

        public int ReservationId { get; set; }
        public ReservationModel reservation { get; set; }

        public int GrillId { get; set; }
        public GrillModel grill { get; set; }
    }
}
