<Query Kind="Statements">
  <Connection>
    <ID>ed4cc7ee-73f7-4c1e-aad4-bea085da2b6b</ID>
    <NamingServiceVersion>3</NamingServiceVersion>
    <Persist>true</Persist>
    <Driver Assembly="EF7Driver" PublicKeyToken="469b5aa5a4331a8c">EF7Driver.StaticDriver</Driver>
    <CustomAssemblyPathEncoded>&lt;UserProfile&gt;\source\repos\NexaWorks\bin\Debug\net10.0\NexaWorks.dll</CustomAssemblyPathEncoded>
    <TargetsAspNet>true</TargetsAspNet>
    <CustomTypeName>NexaWorks.Data.ApplicationDbContext</CustomTypeName>
    <CustomCxString>Server=localhost;Database=NexaWorks;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;</CustomCxString>
    <DriverData>
      <UseDbContextOptions>true</UseDbContextOptions>
      <EFProvider>Microsoft.EntityFrameworkCore.SqlServer</EFProvider>
    </DriverData>
  </Connection>
</Query>

//Cette requête couvre les besoins : 2, 3, 4, 5, 7, 8, 9 et 10
//Avec : 
// - productId = 1 (Trader en Herbe)
//             = 2 (Maître des Investissements)
//			   = 3 (Planificateur d’Entraînement)
//	       	   = 4 (Planificateur d’Anxiété Sociale)
// - versionNumber = null (pour avoir toutes les versions du produit)
// - startDate = null et endDate = null (pour ne pas faire de filtre sur la période)
// - search = null (pour ne pas faire de filtre par mots clés)

int productId = 3;
string versionNumber = "1.1";
DateTime? startDate = new DateTime(2026,7,1,0,0,0);
DateTime? endDate = new DateTime(2026,7,31,23,59,59);
string[] search = new []{"mois", "mensuel", "semaine", "hebdomadaire"};

var query = Tickets
	.Where(t => t.StatusId == 2 
		&& t.ProductVersion.ProductId == productId
		&& (versionNumber == null || t.ProductVersion.VersionNumber == versionNumber)
		&& (startDate == null || t.CreationDate >= startDate) 
		&& (endDate == null || t.CreationDate <= endDate)			
		&& (search == null || search.Any(s => t.IssueDescription.Contains(s))))
	.Select(t => new{t.TicketId,
					t.ProductVersion.Product.Name,
					t.ProductVersion.VersionNumber,
					OSName = t.OperatingSystem.Name,
					StatusName = t.Status.Name,
					t.CreationDate,
					t.IssueDescription,
					t.ResolutionDate,
					t.ResolutionDescription
					});
query.Dump();