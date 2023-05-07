using demo1.Models;
using Microsoft.AspNetCore.Identity;

namespace demo1.Data
{
    public class ApplicationDbInitializer
    {
        public static async Task SeedDatabase(ApplicationDbContext context, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            // Create default roles if they don't already exist
            string[] roleNames = { "Admin", "User" };
            foreach (string roleName in roleNames)
            {
                if (!await roleManager.RoleExistsAsync(roleName))
                {
                    IdentityRole role = new IdentityRole(roleName);
                    await roleManager.CreateAsync(role);
                }
            }

            // Create default admin user if it doesn't already exist
            string adminEmail = "admin2@example.com";
            IdentityUser adminUser = await userManager.FindByEmailAsync(adminEmail);
            if (adminUser == null)
            {
                adminUser = new IdentityUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true
                };

                IdentityResult result = await userManager.CreateAsync(adminUser, "Password@123");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }


            // Create default member user if it doesn't already exist
            string memberEmail = "user@example.com";
            IdentityUser memberUser = await userManager.FindByEmailAsync(memberEmail);
            if (memberUser == null)
            {
                memberUser = new IdentityUser
                {

                    UserName = memberEmail,
                    Email = memberEmail,

                    EmailConfirmed = true
                };

                IdentityResult result = await userManager.CreateAsync(memberUser, "P@ssw0rd");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(memberUser, "User");
                }
            }

            if (!context.Trains.Any())
            {
                List<Train> list = new List<Train>
                {
                    new Train()
                    {
                        TrainId = 1,
                        TrainName = "Vande Bharat",
                        Source = "Pune ",
                        Destination = "Mumbai",
                        DepartureTime = new DateTime(2023, 5, 20, 13, 0, 0),
                        ArrivalTime = new DateTime(2023, 5, 20, 16, 0, 0),
                        TotalSeats = 50,
                        AvailableSeats = 25,
                        Price = 100.00f
                    },
                    new Train()
                    {
                        TrainId = 2,
                        TrainName = "Garibrath Express",
                        Source = "Nashik ",
                        Destination = "Pune",
                        DepartureTime = new DateTime(2023, 5, 19, 2, 0, 0),
                        ArrivalTime = new DateTime(2023, 5, 19, 8, 0, 0),
                        TotalSeats = 100,
                        AvailableSeats = 15,
                        Price = 400.00f
                    },
                    new Train()
                    {
                        TrainId = 3,
                        TrainName = "Intercity Express",
                        Source = "Mumbai",
                        Destination = "Pune",
                        DepartureTime = new DateTime(2023, 5, 18, 2, 0, 0),
                        ArrivalTime = new DateTime(2023, 5, 18, 4, 0, 0),
                        TotalSeats = 60,
                        AvailableSeats = 30,
                        Price = 100.00f
                    },
                    new Train()
                    {
                        TrainId = 4,
                        TrainName = "Anandvan express",
                        Source = "Nagpur",
                        Destination = "Mumbai",
                        DepartureTime = new DateTime(2023, 5, 17, 2, 0, 0),
                        ArrivalTime = new DateTime(2023, 5, 17, 7, 0, 0),
                        TotalSeats = 70,
                        AvailableSeats = 45,
                        Price = 500.00f
                    },
                    new Train()
                    {

                        TrainId = 5,
                        TrainName = "Shalimar Superfast Express",
                        Source = "Shalimar",
                        Destination = "Mumbai",
                        DepartureTime = new DateTime(2023, 5, 10, 1, 0, 0),
                        ArrivalTime = new DateTime(2023, 5, 10, 11, 0, 0),
                        TotalSeats = 80,
                        AvailableSeats = 25,
                        Price = 600.00f
                    }
                };
                context.Trains.AddRange(list);
                context.SaveChanges();
                
            }
            
        }
    }
}
