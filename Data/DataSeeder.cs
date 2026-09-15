using NexaWorks.Models.Entities;

namespace NexaWorks.Data
{
    public static class DataSeeder
    {
        public static async Task SeedAsync(ApplicationDbContext dbContext)
        {
            //Initialisation des différentes compatibilités entre OS et versions de produits
            if (!dbContext.Compatibilities.Any())
            {                
                List<Compatibility> compatibilities = new List<Compatibility>()
                {
                    //Trader en Herbe
                    //-> v1.0
                    new Compatibility{ProductVersionId=1, OSId=1},
                    new Compatibility{ProductVersionId=1, OSId=3},
                    //-> v1.1
                    new Compatibility{ProductVersionId=2, OSId=1},
                    new Compatibility{ProductVersionId=2, OSId=2},
                    new Compatibility{ProductVersionId=2, OSId=3},
                    //-> v1.2
                    new Compatibility{ProductVersionId=3, OSId=1},
                    new Compatibility{ProductVersionId=3, OSId=2},
                    new Compatibility{ProductVersionId=3, OSId=3},
                    new Compatibility{ProductVersionId=3, OSId=4},
                    new Compatibility{ProductVersionId=3, OSId=5},
                    new Compatibility{ProductVersionId=3, OSId=6},
                    //-> v1.3
                    new Compatibility{ProductVersionId=4, OSId=2},
                    new Compatibility{ProductVersionId=4, OSId=3},
                    new Compatibility{ProductVersionId=4, OSId=4},
                    new Compatibility{ProductVersionId=4, OSId=5},
                    //Maître des Investissements
                    //-> v1.0
                    new Compatibility{ProductVersionId=5, OSId=2},
                    new Compatibility{ProductVersionId=5, OSId=5},
                    //-> v2.0
                    new Compatibility{ProductVersionId=6, OSId=2},
                    new Compatibility{ProductVersionId=6, OSId=4},
                    new Compatibility{ProductVersionId=6, OSId=5},
                    //-> v2.1
                    new Compatibility{ProductVersionId=7, OSId=2},
                    new Compatibility{ProductVersionId=7, OSId=3},
                    new Compatibility{ProductVersionId=7, OSId=4},
                    new Compatibility{ProductVersionId=7, OSId=5},
                    //Planificateur d'Entraînement
                    //-> v1.0
                    new Compatibility{ProductVersionId=8, OSId=1},
                    new Compatibility{ProductVersionId=8, OSId=2},
                    //-> v1.2
                    new Compatibility{ProductVersionId=9, OSId=1},
                    new Compatibility{ProductVersionId=9, OSId=2},
                    new Compatibility{ProductVersionId=9, OSId=3},
                    new Compatibility{ProductVersionId=9, OSId=4},
                    new Compatibility{ProductVersionId=9, OSId=5},
                    new Compatibility{ProductVersionId=9, OSId=6},
                    //-> v2.0
                    new Compatibility{ProductVersionId=10, OSId=2},
                    new Compatibility{ProductVersionId=10, OSId=3},
                    new Compatibility{ProductVersionId=10, OSId=4},
                    new Compatibility{ProductVersionId=10, OSId=5},
                    //Planificateur d'Anxiété Sociale
                    //-> v1.0
                    new Compatibility{ProductVersionId=11, OSId=2},
                    new Compatibility{ProductVersionId=11, OSId=3},
                    new Compatibility{ProductVersionId=11, OSId=4},
                    new Compatibility{ProductVersionId=11, OSId=5},
                    //-> v1.1
                    new Compatibility{ProductVersionId=12, OSId=2},
                    new Compatibility{ProductVersionId=12, OSId=3},
                    new Compatibility{ProductVersionId=12, OSId=4},
                    new Compatibility{ProductVersionId=12, OSId=5}
                };
                await dbContext.AddRangeAsync(compatibilities);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
