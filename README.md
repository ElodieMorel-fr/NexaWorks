# NexaWorks

Ce dépôt contient la base de données permettant le suivi des problèmes et leur résolution sur les différentes versions des produits logiciels de **NexaWorks**


## Modèles de données
Les modèles de conception suivants sont disponibles : 
- [Modèle Conceptuel de Données](Docs/MCD.pdf) 
- [Modèle Logique de Données](Docs/MLD.pdf) 

Le Modèle Physique de Données est implémenté à l'aide des migrations Entity Framework Core : 
- [Migration créant les tables](Migrations/20260914085224_InitialModelsCreate.cs)
- [Migration créant les données de paramétrage](Migrations/20260915102534_AddInitialSeedData.cs)


## Base de données
La base de données a été générée selon l'approche Code First d'Entity Framework Core. Les classes d'entités sont disponibles dans le répertoire [Models/Entities](Models/Entities).

Les données de paramétrage sont créées par migrations : 
- Les produits (table Products)
- Les versions de produits (table ProductVersions)
- Les systèmes d'exploitation (table OperatingSystems)
- Les statuts des tickets (table Statuses)

Les données de tests sont initialisées automatiquement via la classe DataSeeder et comprennent : 
-  Les compatibilités entre systèmes d'exploitation et versions de produits (table Compatibilities)
-  25 problèmes dont 17 résolus (table Tickets)
	
La sauvegarde complète de la base de données est disponible dans le répertoire [Database](Database)


## Requêtes métier
Le répertoire [LinqQueries](LinqQueries) contient les requêtes LINQ permettant d'exploiter les données de suivi des problèmes et de répondre aux besoins de reporting et d'analyse


## Technologies utilisées
- ASP.NET Core
- C# 
- SQL-Server
- Entity Framework Core (Code First + Migrations)
- LINQ


## Auteur & Concepteur
Elodie MOREL  
Projet réalisé dans le cadre de la formation OpenClassrooms **Développeur d'application back-end .NET**  
Projet n°6
