using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        // public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDto>
            {
                new CityDto
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park." ,
                    PointsOfInterest = new List<PointsOfInterestDto>()
                    {
                         new PointsOfInterestDto()
                         {
                             Id = 1,
                             Name = "Central Park",
                             Description = "The most visited urban park in the United States."
                         },
                         new PointsOfInterestDto()
                         {
                             Id = 2,
                             Name = "Empire State Building",
                             Description = "A 102-story skyscraper located in Midtown Manhattan."
                         }
                    }
                },
                new CityDto
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never really finished." ,
                     PointsOfInterest = new List<PointsOfInterestDto>()
                    {
                         new PointsOfInterestDto()
                         {
                             Id = 3,
                             Name = "Cathedral of Our Lady",
                             Description = "A Gothic style cathedral, concevived by architects Jan and Piete..."
                         },
                         new PointsOfInterestDto()
                         {
                             Id = 4,
                             Name = "Antwep CEntral Station",
                             Description = "The finest example of railway architecture in Belgium."
                         }
                    }
                },
                new CityDto
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with that big tower.",
                     PointsOfInterest = new List<PointsOfInterestDto>()
                    {
                         new PointsOfInterestDto()
                         {
                             Id = 5,
                             Name = "Eiffel Tower",
                             Description = "A wrought iron lattice tower on the Champ de Mars, named after ..."
                         },
                         new PointsOfInterestDto()
                         {
                             Id = 6,
                             Name = "The Louvre",
                             Description = "The word's largest museum."
                         }
                    }
                }
            };
        }
    }
}
