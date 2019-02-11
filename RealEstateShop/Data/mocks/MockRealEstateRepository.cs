using RealEstateShop.Data.interfaces;
using RealEstateShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateShop.Data.mocks
{
    public class MockRealEstateRepository : IRealEstateRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<RealEstate> RealEstates {
            get
            {
                return new List<RealEstate>
                {
                    new RealEstate {
                        Price = 75000,
                        SquareMeters = 65,
                        ShortDescription = "Small and cosy apartment",
                        LongDescription = "Small and cosy apartment with a bedroom, a living room and a nice kitchen",
                        IsRealEstatePreffered = false,
                        Type = "apartment",
                        ImageUrl = "https://07f138315bb5e97f9e43-31068357019044cca7c8e84d92de0d99.ssl.cf3.rackcdn.com/1024x768/56587_11491_001.jpg",
                        ImageThumbnailUrl = "https://07f138315bb5e97f9e43-31068357019044cca7c8e84d92de0d99.ssl.cf3.rackcdn.com/1024x768/56587_11491_001.jpg",
                        Category = _categoryRepository.Categories.First()
                    },
                    new RealEstate {
                        Price = 175000,
                        SquareMeters = 105,
                        ShortDescription = "Nice and big apartment",
                        LongDescription = "Nice and big apartment with 2 bedrooms, a living room and a nice kitchen",
                        IsRealEstatePreffered = true,
                        Type = "apartment",
                        ImageUrl = "https://07f138315bb5e97f9e43-31068357019044cca7c8e84d92de0d99.ssl.cf3.rackcdn.com/1024x768/56587_11491_001.jpg",
                        ImageThumbnailUrl = "https://07f138315bb5e97f9e43-31068357019044cca7c8e84d92de0d99.ssl.cf3.rackcdn.com/1024x768/56587_11491_001.jpg",
                        Category = _categoryRepository.Categories.Last()
                    },
                    new RealEstate {
                        Price = 300000,
                        SquareMeters = 300,
                        ShortDescription = "A big house",
                        LongDescription = "A big houseon three floors",
                        IsRealEstatePreffered = true,
                        Type = "house",
                        ImageUrl = "http://www.safesurfincentral.com/wp-content/uploads/2018/09/the-kelvin-apartments-exterior.jpg",
                        ImageThumbnailUrl = "http://www.safesurfincentral.com/wp-content/uploads/2018/09/the-kelvin-apartments-exterior.jpg",
                        Category = _categoryRepository.Categories.First()
                    },
                    new RealEstate {
                        Price = 200000,
                        SquareMeters = 200,
                        ShortDescription = "A small house",
                        LongDescription = "A Small and cosy house with a bedroom, livingroom and a nice kitchen",
                        IsRealEstatePreffered = false,
                        Type = "house",
                        ImageUrl = "http://www.safesurfincentral.com/wp-content/uploads/2018/09/the-kelvin-apartments-exterior.jpg",
                        ImageThumbnailUrl = "http://www.safesurfincentral.com/wp-content/uploads/2018/09/the-kelvin-apartments-exterior.jpg",
                        Category = _categoryRepository.Categories.Last()
                    }
                };
            }
        }

        public IEnumerable<RealEstate> PreferredRealEstates
        {
            get
            {
                return new List<RealEstate>
                {
                    new RealEstate {
                        Price = 175000,
                        SquareMeters = 105,
                        ShortDescription = "Nice and big apartment",
                        LongDescription = "Nice and big apartment with 2 bedrooms, a living room and a nice kitchen",
                        IsRealEstatePreffered = true,
                        Type = "apartment",
                        ImageUrl = "https://07f138315bb5e97f9e43-31068357019044cca7c8e84d92de0d99.ssl.cf3.rackcdn.com/1024x768/56587_11491_001.jpg",
                        ImageThumbnailUrl = "https://07f138315bb5e97f9e43-31068357019044cca7c8e84d92de0d99.ssl.cf3.rackcdn.com/1024x768/56587_11491_001.jpg",
                        Category = _categoryRepository.Categories.Last()
                    },
                    new RealEstate {
                        Price = 300000,
                        SquareMeters = 300,
                        ShortDescription = "A big house",
                        LongDescription = "A big houseon three floors",
                        IsRealEstatePreffered = true,
                        Type = "house",
                        ImageUrl = "http://www.safesurfincentral.com/wp-content/uploads/2018/09/the-kelvin-apartments-exterior.jpg",
                        ImageThumbnailUrl = "http://www.safesurfincentral.com/wp-content/uploads/2018/09/the-kelvin-apartments-exterior.jpg",
                        Category = _categoryRepository.Categories.First()
                    }
                };
            }
        }

        public RealEstate GetRealEstateById(int realEstateId)
        {
            throw new NotImplementedException();
        }
    }
}
