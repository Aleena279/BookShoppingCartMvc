using BookShoppingCartMvcUI.Constants;
using BookShoppingCartMvcUI.Models;
using Microsoft.AspNetCore.Identity;
using System;

namespace BookShoppingCartMvcUI.Data
{
    public class DbSeeder
    {
        //public static async Task SeedDefaultData(IServiceProvider service)
        //{
            //            var userMgr = service.GetService<UserManager<IdentityUser>>();
            //            var roleMgr = service.GetService<RoleManager<IdentityRole>>();

            //            await roleMgr.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            //            await roleMgr.CreateAsync(new IdentityRole(Roles.User.ToString()));

            //            var admin = new IdentityUser
            //            {
            //                UserName = "admin@gmail.com",
            //                Email = "admin@gmail.com",
            //                EmailConfirmed = true
            //            };

            //            var userInDb = await userMgr.FindByEmailAsync(admin.Email);

            //            if (userInDb is null)
            //            {
            //                await userMgr.CreateAsync(admin, "Admin@123");
            //                await userMgr.AddToRoleAsync(admin, Roles.Admin.ToString());
            //            }

                 //}
            public static void Seed(IApplicationBuilder applicationBuilder)
{
    using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
    {
        var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

        context.Database.EnsureCreated();

                //                //Genre
                //                if (!context.Genres.Any())
                //                {
                //                    context.Genres.AddRange(new List<Genre>()
                //                    {
                //                        new Genre()
                //                        {
                //                            GenreName = "Adventure"
                //                        },

                //                        new Genre()
                //                        {
                //                            GenreName = "Science Fiction"
                //                        },

                //                        new Genre()
                //                        {
                //                            GenreName = "Romance"
                //                        },

                //                        new Genre()
                //                        {
                //                            GenreName = "Horror"
                //                        },
                //                    });
                //                    context.SaveChanges();
                //                }

                //                if (!context.Books.Any())
                //                {
                //                    context.Books.AddRange(new List<Book>()
                //                    {
                //                        new Book()
                //    {
                //        BookName = "The Lost Island",
                //        AuthorName = "Clive Cussler",
                //        Price = 15.99,
                //        Image = "https://example.com/lost_island.jpg",
                //        GenreId = 1,
                //    },
                //    new Book()
                //    {
                //        BookName = "Journey to Mars",
                //        AuthorName = "Arthur C. Clarke",
                //        Price = 18.50,
                //        Image = "https://example.com/journey_mars.jpg",
                //        GenreId = 2,
                //    },
                //    new Book()
                //    {
                //        BookName = "Love in Paris",
                //        AuthorName = "Nicholas Sparks",
                //        Price = 12.99,
                //        Image = "https://example.com/love_paris.jpg",
                //        GenreId = 3,
                //    },
                //    new Book()
                //    {
                //        BookName = "Haunted Manor",
                //        AuthorName = "Stephen King",
                //        Price = 20.00,
                //        Image = "https://example.com/haunted_manor.jpg",
                //        GenreId = 4,
                //    },
                //    new Book()
                //    {
                //        BookName = "The Treasure Hunt",
                //        AuthorName = "Wilbur Smith",
                //        Price = 16.75,
                //        Image = "https://example.com/treasure_hunt.jpg",
                //        GenreId = 1,
                //    },
                //    new Book()
                //    {
                //        BookName = "Galactic Wars",
                //        AuthorName = "Isaac Asimov",
                //        Price = 22.40,
                //        Image = "https://example.com/galactic_wars.jpg",
                //        GenreId = 2,
                //    },
                //    new Book()
                //    {
                //        BookName = "The Last Letter",
                //        AuthorName = "Jojo Moyes",
                //        Price = 14.20,
                //        Image = "https://example.com/last_letter.jpg",
                //        GenreId = 3,
                //    },
                //    new Book()
                //    {
                //        BookName = "Nightmares Unleashed",
                //        AuthorName = "H.P. Lovecraft",
                //        Price = 19.80,
                //        Image = "https://example.com/nightmares.jpg",
                //        GenreId = 4,
                //    },
                //    new Book()
                //    {
                //        BookName = "Into the Wild",
                //        AuthorName = "Jon Krakauer",
                //        Price = 14.95,
                //        Image = "https://example.com/into_the_wild.jpg",
                //        GenreId = 1,
                //    },
                //    new Book()
                //    {
                //        BookName = "The Adventures of Tintin",
                //        AuthorName = "Hergé",
                //        Price = 12.50,
                //        Image = "https://example.com/adventures_of_tintin.jpg",
                //        GenreId = 1,
                //    },
                //    new Book()
                //    {
                //        BookName = "Treasure Island",
                //        AuthorName = "Robert Louis Stevenson",
                //        Price = 10.99,
                //        Image = "https://example.com/treasure_island.jpg",
                //        GenreId = 1,
                //    },

                //    new Book()
                //    {
                //        BookName = "Dune",
                //        AuthorName = "Frank Herbert",
                //        Price = 19.99,
                //        Image = "https://example.com/dune.jpg",
                //        GenreId = 2,
                //    },
                //    new Book()
                //    {
                //        BookName = "Ender's Game",
                //        AuthorName = "Orson Scott Card",
                //        Price = 15.75,
                //        Image = "https://example.com/enders_game.jpg",
                //        GenreId = 2,
                //    },
                //    new Book()
                //    {
                //        BookName = "The Martian",
                //        AuthorName = "Andy Weir",
                //        Price = 17.50,
                //        Image = "https://example.com/the_martian.jpg",
                //        GenreId = 2,
                //    },
                //    new Book()
                //    {
                //        BookName = "Pride and Prejudice",
                //        AuthorName = "Jane Austen",
                //        Price = 9.99,
                //        Image = "https://example.com/pride_and_prejudice.jpg",
                //        GenreId = 3,
                //    },
                //    new Book()
                //    {
                //        BookName = "Me Before You",
                //        AuthorName = "Jojo Moyes",
                //        Price = 16.00,
                //        Image = "https://example.com/me_before_you.jpg",
                //        GenreId = 3,
                //    },
                //    new Book()
                //    {
                //        BookName = "The Notebook",
                //        AuthorName = "Nicholas Sparks",
                //        Price = 11.50,
                //        Image = "https://example.com/the_notebook.jpg",
                //        GenreId = 3,
                //    },

                //    new Book()
                //    {
                //        BookName = "The Shining",
                //        AuthorName = "Stephen King",
                //        Price = 22.00,
                //        Image = "https://example.com/the_shining.jpg",
                //        GenreId = 4,
                //    },
                //    new Book()
                //    {
                //        BookName = "Dracula",
                //        AuthorName = "Bram Stoker",
                //        Price = 12.00,
                //        Image = "https://example.com/dracula.jpg",
                //        GenreId = 4,
                //    },
                //    new Book()
                //    {
                //        BookName = "Frankenstein",
                //        AuthorName = "Mary Shelley",
                //        Price = 14.00,
                //        Image = "https://example.com/frankenstein.jpg",
                //        GenreId = 4,
                //    },


                //                    });
                //                    context.SaveChanges();
                //                }

                if (!context.OrderStatuses.Any())
                {
                    context.OrderStatuses.AddRange(new List<OrderStatus>()
                                    {
                                        new OrderStatus()
                                        {
                                            StatusId = 1,   
                                            StatusName = "Pending",
                                        },
                                         new OrderStatus()
                                        {
                                            StatusId = 2,
                                            StatusName = "Shipped",
                                        },
                                          new OrderStatus()
                                        {
                                            StatusId = 3,
                                            StatusName = "Delivered",
                                        },
                                           new OrderStatus()
                                        {
                                            StatusId = 4,
                                            StatusName = "Cancelled",
                                        },
                                            new OrderStatus()
                                        {
                                            StatusId = 5,
                                            StatusName = "Returned",
                                        },
                                            new OrderStatus()
                                        {
                                            StatusId = 6,
                                            StatusName = "Refund",
                                        },

                                        });
                    context.SaveChanges();
                }
            }



            }
    }


}

