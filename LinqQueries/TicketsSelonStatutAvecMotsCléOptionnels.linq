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

//Cette requête couvre les besoins : 1, 6, 11 et 16
//Avec : 
//- statusId = 1 (Résolu)
//			 = 2 (En cours)
//- search = null (pour ne pas faire de filtre par mots clés)
//- search = new []{"portefeuille", "action", "montant"} (pour filtrer sur les problèmes dont la description contient au moins un des mots clés donnés)

int statusId = 1;
string[] search = new []{"portefeuille", "action", "montant"}; 

var query = Tickets
	.Where(t => t.StatusId == statusId
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