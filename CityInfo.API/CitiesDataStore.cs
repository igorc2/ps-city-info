using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "Big apple",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {

                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "Big park"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "Big building"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Lavras",
                    Description = "Cidade dos Ipês",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {

                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Ufla",
                            Description = "Big university"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Train station",
                            Description = "Old train station"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "São Paulo",
                    Description = "Cidade sem amor",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {

                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Loveless",
                            Description = "Lack of love"
                        }
                    }
                }
            };
        }
    }
}
