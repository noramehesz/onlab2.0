using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class GrillBerContext : IdentityDbContext<AppUser>
    {
        public GrillBerContext(DbContextOptions<GrillBerContext> options)
            : base(options)
        { }

        public DbSet<GrillModel> Grills { get; set; }
        public DbSet<ReservationModel> Reservations { get; set; }
       
        
       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Ignore<IdentityUserLogin<string>>();
            modelBuilder.Ignore<IdentityUserRole<string>>();
            //modelBuilder.Ignore<IdentityUserClaim<string>>();
            modelBuilder.Ignore<IdentityUserToken<string>>();
            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(
                 new AppUser
                 {
                     Id = "1",
                     Email = "janos@gmail.com",
                     NormalizedEmail = "janos@gmail.com",
                     UserName = "janos@gmail.com",
                     NormalizedUserName = "janos@gmail.com",
                     EmailConfirmed = false,
                     PasswordHash = hasher.HashPassword(null, "asdasd"),
                     SecurityStamp = string.Empty
                 },

                 new AppUser
                 {
                     Id = "2",
                     Email = "julia@hotmail.com",
                     NormalizedEmail = "julia@hotmail.com",
                     UserName = "julia@hotmail.com",
                     NormalizedUserName = "julia@hotmail.com",
                     EmailConfirmed = false,
                     PasswordHash = hasher.HashPassword(null, "szeretemromeot"), 
                     SecurityStamp = string.Empty
                 }
                );

            modelBuilder.Entity<ReservationModel>().HasData(
                 new ReservationModel
                 {
                     ReservationId = 1,
                     ReservationDate = DateTime.Parse("2019-4-23"),
                     ReservatorName = "Kiss Janos",
                     ReservationAddress = "Budapest 7. kerület Wesselényi utca 56.",
                     UserId = "1"
                 },

                 new ReservationModel
                 {
                     ReservationId = 2,
                     ReservationDate = DateTime.Parse("2019-2-10"),
                     ReservatorName = "Kiss Janos",
                     ReservationAddress = "Budapest Újpest központi parkoló",
                     UserId = "1"
                    // ReservGrills = new List<ReservGrill>()
                 },

                 new ReservationModel
                 {
                     ReservationId = 3,
                     ReservationDate = DateTime.Parse("2019-05-03"),
                     ReservatorName = "Kiss Janos",
                     ReservationAddress = "Bp 14. ker",
                     UserId = "1"
                 }

                );


            modelBuilder.Entity<GrillModel>().HasData(
                new GrillModel
                {
                    GrillId = 1,
                    GrillType = "charcoal grill",
                    GrillDecription = "in new condition",
                    GrillPricePerHour = 1500,
                    //ReservationId = 1
                },

            
                new GrillModel
                {
                    GrillId = 2,
                    GrillType = "gas grill",
                    GrillDecription = "red coloured grill",
                    GrillPricePerHour = 2500,
                    //ReservationId = 1
                },

                new GrillModel
                {
                    GrillId = 3,
                    GrillType = "gas grill",
                    GrillDecription = "brandnew grill with free towel",
                    GrillPricePerHour = 3000
                }
            );

            modelBuilder.Entity<GrillReservation>().HasData(
                new GrillReservation
                {
                    Id = 1,
                    ReservationId = 1,
                    GrillId = 1
                },

                new GrillReservation
                {
                    Id = 2,
                    ReservationId = 2,
                    GrillId = 3
                },

                new GrillReservation
                {
                    Id = 3,
                    ReservationId = 3,
                    GrillId = 3
                }
                
                );



        }

    }
}
