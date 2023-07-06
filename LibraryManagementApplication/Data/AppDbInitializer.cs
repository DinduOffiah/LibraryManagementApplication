using LibraryManagementApplication.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementApplication.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();


                // Students
                if (!context.Students.Any())
                {
                    context.Students.AddRange(new List<Student>()
                    {
                        new Student()
                        {
                            RegNo = 001,
                            Lastname = "Okocha",
                            OtherName = "Charlse",
                            Email = "okochac@gmail.com",
                            Address = "Lekki Phase 1",
                            PhoneNum = "07084746363",
                            Department = "Theatre and Art",
                        },
                        new Student()
                        {
                            RegNo = 002,
                            Lastname = "Azubuike",
                            OtherName = "Chibuzor",
                            Email = "phyno@gmail.com",
                            Address = "Lekki Phase 1",
                            PhoneNum = "070847546363",
                            Department = "Music",
                        },
                        new Student()
                        {
                            RegNo = 003,
                            Lastname = "Iheanacho",
                            OtherName = "Kelechi",
                            Email = "ken@gmail.com",
                            Address = "London",
                            PhoneNum = "07084749363",
                            Department = "Football",
                        },
                        new Student()
                        {
                            RegNo = 004,
                            Lastname = "Obi",
                            OtherName = "Cubana",
                            Email = "obic@gmail.com",
                            Address = "Ikoyi",
                            PhoneNum = "07084746313",
                            Department = "Business",
                        },
                        new Student()
                        {
                            RegNo = 005,
                            Lastname = "Ganja",
                            OtherName = "Divine",
                            Email = "gc@gmail.com",
                            Address = "Apapa",
                            PhoneNum = "07084746361",
                            Department = "Law",
                        }
                    });
                    context.SaveChanges();
                }


                // Lecturers
                if (!context.Lecturers.Any())
                {
                    context.Lecturers.AddRange(new List<Lecturer>()
                    {
                        new Lecturer()
                        {
                            StaffNo = 011,
                            Lastname = "Obi",
                            OtherName = "Peter",
                            Email = "peterobi@gmail.com",
                            Address = "Awka",
                            PhoneNum = "08084746363",
                            Department = "Economics",
                        },
                        new Lecturer()
                        {
                            StaffNo = 012,
                            Lastname = "Abubakar",
                            OtherName = "Atiku",
                            Email = "atibu@gmail.com",
                            Address = "Maitama",
                            PhoneNum = "080847546363",
                            Department = "Business",
                        },
                        new Lecturer()
                        {
                            StaffNo = 013,
                            Lastname = "Tinubu",
                            OtherName = "Bola",
                            Email = "jagaban@gmail.com",
                            Address = "Ikoyi",
                            PhoneNum = "08084749363",
                            Department = "Politics",
                        },
                        new Lecturer()
                        {
                            StaffNo = 014,
                            Lastname = "Mbah",
                            OtherName = "Peter",
                            Email = "pmbah@gmail.com",
                            Address = "Enugu",
                            PhoneNum = "08084746313",
                            Department = "Business",
                        },
                        new Lecturer()
                        {
                            StaffNo = 015,
                            Lastname = "Nweke",
                            OtherName = "Frank",
                            Email = "fnweke@gmail.com",
                            Address = "Enugu",
                            PhoneNum = "08084746361",
                            Department = "Politics",
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
