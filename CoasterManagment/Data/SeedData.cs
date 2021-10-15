using CoasterManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoasterManagment.Data
{
    public static class SeedData
    {
        public static List<Coaster> Coasters = new List<Coaster>()
        {
            new Coaster(){
                Color = "Red",
                Id = Guid.NewGuid().ToString(),
                Type = "Accelerator",
                Size = 14,
                Rating = 1,
                CreatedDate = DateTime.Now.AddDays(-1),
                ModifiedDate =  DateTime.Now.AddDays(-1),
            },
            new Coaster(){
                Color = "Orange",
                Id = Guid.NewGuid().ToString(),
                Type = "BobsledRoller",
                Rating = 2,
                Size = 12,
                CreatedDate = DateTime.Now.AddDays(-1),
                ModifiedDate =  DateTime.Now.AddDays(-1),
            },
            new Coaster(){
                Color = "Black",
                Id = Guid.NewGuid().ToString(),
                Type = "InvertedRoller",
                Size = 16,
                Rating = 2,
                CreatedDate = DateTime.Now.AddDays(-2),
                ModifiedDate =  DateTime.Now.AddDays(-2),
            },
            new Coaster(){
                Color = "Blue",
                Id = Guid.NewGuid().ToString(),
                Type = "Dive",
                Size = 20,
                Rating = 3,
                CreatedDate = DateTime.Now.AddDays(-3),
                ModifiedDate =  DateTime.Now.AddDays(-3),
            },
            new Coaster(){
                Color = "White",
                Id = Guid.NewGuid().ToString(),
                Type = "FloorlessRoller",
                Size = 18,
                Rating = 4,
                CreatedDate = DateTime.Now.AddDays(-3),
                ModifiedDate =  DateTime.Now.AddDays(-3),
            },
            new Coaster(){
                Color = "Black",
                Id = Guid.NewGuid().ToString(),
                Type = "InvertedRoller",
                Size = 18,
                Rating = 4,
                CreatedDate = DateTime.Now.AddDays(-4),
                ModifiedDate =  DateTime.Now.AddDays(-4),
            },
            new Coaster(){
                Color = "Brown",
                Id = Guid.NewGuid().ToString(),
                 Type = "StandUp",
                Size = 22,
                Rating = 4,
                CreatedDate = DateTime.Now.AddDays(-4),
                ModifiedDate =  DateTime.Now.AddDays(-4),
            },
            new Coaster(){
                Color = "Yellow",
                Id = Guid.NewGuid().ToString(),
                Type = "BobsledRoller",
                Size = 12,
                Rating = 1,
                CreatedDate = DateTime.Now.AddDays(-5),
                ModifiedDate =  DateTime.Now.AddDays(-5),
            },
            new Coaster(){
                Color = "Orange",
                Id = Guid.NewGuid().ToString(),
                Type = "FlyingRoller",
                Size = 10,
                Rating = 5,
                CreatedDate = DateTime.Now.AddDays(-5),
                ModifiedDate =  DateTime.Now.AddDays(-5),
            },
            new Coaster(){
                Color = "White",
                Id = Guid.NewGuid().ToString(),
                Type = "Accelerator",
                Size = 14,
                Rating = 4,
                CreatedDate = DateTime.Now.AddDays(-6),
                ModifiedDate =  DateTime.Now.AddDays(-6),
            },
        };
    }
}