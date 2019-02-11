using RealEstateShop.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace RealEstateShop.Data
{
    public class DbInitializer
    {
        private static AppDbContext context;

        public DbInitializer(AppDbContext appDbContext)
        {
            context = appDbContext;
        }
        public void Seed()
        {
            if (!context.Departments.Any())
            {
                context.Departments.AddRange(Departments.Select(d => d.Value));
            }

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.RealEstates.Any())
            {
                context.AddRange
                (
                    new RealEstate
                    {
                        Price = 75000,
                        SquareMeters = 65,
                        ShortDescription = "Small and cosy apartment",
                        LongDescription = "Small and cosy apartment with a bedroom, a living room and a nice kitchen",
                        IsRealEstatePreffered = false,
                        Type = "apartment",
                        ImageUrl = "http://www.safesurfincentral.com/wp-content/uploads/2018/09/the-kelvin-apartments-exterior.jpg",
                        ImageThumbnailUrl = "http://www.safesurfincentral.com/wp-content/uploads/2018/09/the-kelvin-apartments-exterior.jpg",
                        Category = Categories["east-south"]
                    },
                    new RealEstate
                    {
                        Price = 175000,
                        SquareMeters = 105,
                        ShortDescription = "Nice and big apartment",
                        LongDescription = "Nice and big apartment with 2 bedrooms, a living room and a nice kitchen",
                        IsRealEstatePreffered = true,
                        Type = "apartment",
                        ImageUrl = "http://www.safesurfincentral.com/wp-content/uploads/2018/09/the-kelvin-apartments-exterior.jpg",
                        ImageThumbnailUrl = "http://www.safesurfincentral.com/wp-content/uploads/2018/09/the-kelvin-apartments-exterior.jpg",
                        Category = Categories["middle-south"]
                    },
                    new RealEstate
                    {
                        Price = 300000,
                        SquareMeters = 300,
                        ShortDescription = "A big house",
                        LongDescription = "A big houseon three floors",
                        IsRealEstatePreffered = true,
                        Type = "house",
                        ImageUrl = "http://www.safesurfincentral.com/wp-content/uploads/2018/09/the-kelvin-apartments-exterior.jpg",
                        ImageThumbnailUrl = "http://www.safesurfincentral.com/wp-content/uploads/2018/09/the-kelvin-apartments-exterior.jpg",
                        Category = Categories["west-south"]
                    },
                    new RealEstate
                    {
                        Price = 200000,
                        SquareMeters = 200,
                        ShortDescription = "A small house",
                        LongDescription = "A Small and cosy house with a bedroom, livingroom and a nice kitchen",
                        IsRealEstatePreffered = false,
                        Type = "house",
                        ImageUrl = "http://www.safesurfincentral.com/wp-content/uploads/2018/09/the-kelvin-apartments-exterior.jpg",
                        ImageThumbnailUrl = "http://www.safesurfincentral.com/wp-content/uploads/2018/09/the-kelvin-apartments-exterior.jpg",
                        Category = Categories["east-north"]
                    },
                    new RealEstate
                    {
                        Price = 75000,
                        SquareMeters = 65,
                        ShortDescription = "Small and cosy apartment",
                        LongDescription = "Small and cosy apartment with a bedroom, a living room and a nice kitchen",
                        IsRealEstatePreffered = false,
                        Type = "apartment",
                        ImageUrl = "http://www.safesurfincentral.com/wp-content/uploads/2018/09/the-kelvin-apartments-exterior.jpg",
                        ImageThumbnailUrl = "http://www.safesurfincentral.com/wp-content/uploads/2018/09/the-kelvin-apartments-exterior.jpg",
                        Category = Categories["middle-north"]
                    },
                    new RealEstate
                    {
                        Price = 175000,
                        SquareMeters = 105,
                        ShortDescription = "Nice and big apartment",
                        LongDescription = "Nice and big apartment with 2 bedrooms, a living room and a nice kitchen",
                        IsRealEstatePreffered = true,
                        Type = "apartment",
                        ImageUrl = "http://www.safesurfincentral.com/wp-content/uploads/2018/09/the-kelvin-apartments-exterior.jpg",
                        ImageThumbnailUrl = "http://www.safesurfincentral.com/wp-content/uploads/2018/09/the-kelvin-apartments-exterior.jpg",
                        Category = Categories["west-north"]
                    },
                    new RealEstate
                    {
                        Price = 300000,
                        SquareMeters = 300,
                        ShortDescription = "A big house",
                        LongDescription = "A big houseon three floors",
                        IsRealEstatePreffered = true,
                        Type = "house",
                        ImageUrl = "http://www.safesurfincentral.com/wp-content/uploads/2018/09/the-kelvin-apartments-exterior.jpg",
                        ImageThumbnailUrl = "http://www.safesurfincentral.com/wp-content/uploads/2018/09/the-kelvin-apartments-exterior.jpg",
                        Category = Categories["east-north"]
                    },
                    new RealEstate
                    {
                        Price = 200000,
                        SquareMeters = 200,
                        ShortDescription = "A small house",
                        LongDescription = "A Small and cosy house with a bedroom, livingroom and a nice kitchen",
                        IsRealEstatePreffered = false,
                        Type = "house",
                        ImageUrl = "http://www.safesurfincentral.com/wp-content/uploads/2018/09/the-kelvin-apartments-exterior.jpg",
                        ImageThumbnailUrl = "http://www.safesurfincentral.com/wp-content/uploads/2018/09/the-kelvin-apartments-exterior.jpg",
                        Category = Categories["east-north"]
                    }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Department> departments;
        public static Dictionary<string, Department> Departments
        {
            get
            {
                if (departments == null)
                {
                    var genresList = new Department[]
                    {
                        new Department { Name = "South", Description = "South Department" },
                        new Department { Name = "North", Description = "North Department" }
                    };

                    departments = new Dictionary<string, Department>();

                    foreach (Department genre in genresList)
                    {
                        departments.Add(genre.Name, genre);
                    }
                }

                return departments;
            }
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category {
                            Name = "East",
                            Description = "east-south",
                            Department = Departments["South"]
                        },
                         new Category {
                            Name = "Middle",
                            Description = "middle-south",
                            Department = Departments["South"]
                        },
                        new Category {
                            Name = "West",
                            Description = "west-south",
                            Department = Departments["South"]
                        },
                        new Category {
                            Name = "East",
                            Description = "east-north",
                            Department = Departments["North"]
                        },
                        new Category {
                            Name = "Middle",
                            Description = "middle-north",
                            Department = Departments["North"]
                        },
                        new Category {
                            Name = "West",
                            Description = "west-north",
                            Department = Departments["North"]
                        }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.Description, genre);
                    }
                }

                return categories;
            }
        }
    }
}