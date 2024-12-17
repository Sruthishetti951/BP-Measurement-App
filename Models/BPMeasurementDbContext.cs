using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace BPMeasurmentApp.Models
{
    public class BPMeasurementDbContext: DbContext
    {

        public BPMeasurementDbContext(DbContextOptions<BPMeasurementDbContext>options): base(options) { }
        public DbSet<BPMeasurementModel> BPMeasurementSet { get; set; }
        public DbSet<Position> Position { get; set; }

        //This metod seeds position and initial measurements to DB
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Position>().HasData(
                new Position
                {
                    PositionID=1,
                    PositionName="Sitting"
                },
                 new Position
                 {
                     PositionID = 2,
                     PositionName = "Standing"
                 },
                  new Position
                  {
                      PositionID = 3,
                      PositionName = "Lying Down"
                  }
                );

            modelBuilder.Entity<BPMeasurementModel>().HasData(
                new BPMeasurementModel
                {
                    ID = 1,
                    Systolic=110,
                    Diastolic=70,
                    DateTaken=DateTime.Now,
                    PositionID = 1,
                },
                new BPMeasurementModel
                {
                    ID = 2,
                    Systolic = 180,
                    Diastolic = 12,
                    DateTaken = DateTime.Now,
                    PositionID = 2,
                },
                new BPMeasurementModel
                {
                    ID = 3,
                    Systolic = 140,
                    Diastolic = 90,
                    DateTaken = DateTime.Now,
                    PositionID = 3,
                },
                new BPMeasurementModel
                {
                    ID = 4,
                    Systolic = 130,
                    Diastolic = 85,
                    DateTaken = DateTime.Now,
                    PositionID = 1,
                },
                new BPMeasurementModel
                {
                    ID = 5,
                    Systolic = 121,
                    Diastolic = 65,
                    DateTaken = DateTime.Now,
                    PositionID = 2
                }

                );
        }
       
    
    }
}
