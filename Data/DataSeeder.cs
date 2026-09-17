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
                await CompatibilitiesSeedAsync(dbContext);
            }

            //Initialisation des tickets
            if(!dbContext.Tickets.Any())
            {
                await TicketsSeedAsync(dbContext);
            }
        }

        private static async Task CompatibilitiesSeedAsync(ApplicationDbContext dbContext)
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

        private static async Task TicketsSeedAsync(ApplicationDbContext dbContext)
        {
            List<Ticket> tickets = new List<Ticket>()
            {
                //Ticket 1
                new Ticket{ProductVersionId=1, OSId=1, StatusId=1, CreationDate=new DateTime(2026,3,8), ResolutionDate=new DateTime(2026,3,10),
                    IssueDescription="""Après avoir acheté ou vendu des actions puis actualisé son portefeuille, le montant total affiché ne change pas. L’utilisateur doit fermer puis rouvrir l’application pour voir la valeur correcte de son portefeuille.""",
                    ResolutionDescription="""Un mécanisme de cache conservait l’ancienne valeur du portefeuille. Le cache est désormais invalidé après chaque achat ou vente."""},

                //Ticket 2
                new Ticket{ProductVersionId=2, OSId=2, StatusId=1, CreationDate=new DateTime(2026,3,14), ResolutionDate=new DateTime(2026,3,20),
                    IssueDescription="""Lorsque l’utilisateur revient sur l’application après avoir laissé son ordinateur en veille, les graphiques des actions restent vides. Les prix et l’évolution des cours ne réapparaissent pas, même après avoir changé d’écran.""",
                    ResolutionDescription="""La connexion au service de cotations n’était pas rétablie à la sortie de veille. Une reconnexion automatique a été ajoutée."""},

                //Ticket 3
                new Ticket{ProductVersionId=3, OSId=4, StatusId=1, CreationDate=new DateTime(2026,3,25), ResolutionDate=new DateTime(2026,3,29),
                    IssueDescription="""L’utilisateur recherche l’action « Énergies du Futur » dans la barre de recherche. Aucun résultat n’est affiché alors que l’action existe bien. Si l’utilisateur omet l’accent et saisit « Energies du Futur », l’action est bien trouvée.""",
                    ResolutionDescription="""La recherche ne normalisait pas les caractères accentués. Les requêtes sont maintenant comparées sans tenir compte des accents."""},

                //Ticket 4
                new Ticket{ProductVersionId=3, OSId=6, StatusId=2, CreationDate=new DateTime(2026,4,3),
                    IssueDescription="""L’utilisateur souhaite acheter des actions depuis son téléphone, mais le clavier virtuel recouvre le champ ou le bouton de confirmation. Il ne peut donc pas vérifier le montant ni terminer son achat sans fermer le clavier."""},

                //Ticket 5
                new Ticket{ProductVersionId=4, OSId=5, StatusId=1, CreationDate=new DateTime(2026,4,12), ResolutionDate=new DateTime(2026,4,14),
                    IssueDescription="""L’utilisateur souhaite retirer une action qu’il ne suit plus de sa liste de favoris. Lorsqu’il appuie sur le bouton de suppression, rien ne se passe et l’action reste dans la liste.""",
                    ResolutionDescription="""Le bouton de suppression ne réagissait pas sur iOS. Son fonctionnement a été corrigé."""},

                //Ticket 6
                new Ticket{ProductVersionId=4, OSId=3, StatusId=2, CreationDate=new DateTime(2026,4,22),
                    IssueDescription="""Après avoir vendu des actions, l’utilisateur constate que l’argent obtenu n’apparaît pas dans son solde disponible. Il pense que la vente n’a pas été prise en compte, car le montant affiché reste identique."""},

                //Ticket 7
                new Ticket{ProductVersionId=3, OSId=1, StatusId=1, CreationDate=new DateTime(2026,5,2), ResolutionDate=new DateTime(2026,5,5),
                    IssueDescription="""Le montant des frais de courtage est affiché avec un point décimal au lieu d’une virgule.""",
                    ResolutionDescription="""Le paramètre régional du système n’était pas pris en compte. Le format monétaire est désormais adapté à la langue de l’utilisateur."""},

                //Ticket 8
                new Ticket{ProductVersionId=5, OSId=2, StatusId=1, CreationDate=new DateTime(2026,5,9), ResolutionDate=new DateTime(2026,5,11),
                    IssueDescription="""L’utilisateur remplit un formulaire pour créer un objectif d’investissement, mais fait une erreur dans un champ. Après la validation, tous les champs qu’il avait déjà renseignés sont effacés et il doit recommencer entièrement.""",
                    ResolutionDescription="""Les données du formulaire sont maintenant conservées lorsque l’utilisateur doit corriger un champ."""},

                //Ticket 9
                new Ticket{ProductVersionId=5, OSId=5, StatusId=1, CreationDate=new DateTime(2026,5,18), ResolutionDate=new DateTime(2026,5,24),
                    IssueDescription="""L’utilisateur ouvre le détail du fonds « Croissance & Épargne Europe » présent dans son portefeuille. L’application se ferme brusquement et il doit la relancer. Ce problème se produit sur tous les fonds dont le nom contient un caractère spécial.""",
                    ResolutionDescription="""Le contenu reçu du service de données n’était pas correctement encodé. La lecture des noms de fonds a été corrigée."""},

                //Ticket 10
                new Ticket{ProductVersionId=6, OSId=4, StatusId=2, CreationDate=new DateTime(2026,5,30),
                    IssueDescription="""L’utilisateur modifie le nom de l’un de ses portefeuilles, puis revient sur le menu principal. Il constate que l’ancien nom est toujours affiché, ce qui lui donne l’impression que sa modification n’a pas été enregistrée."""},

                //Ticket 11
                new Ticket{ProductVersionId=6, OSId=2, StatusId=2, CreationDate=new DateTime(2026,6,6),
                    IssueDescription="""L’utilisateur réduit la fenêtre de l’application pour travailler à côté d’un autre logiciel. Le bouton permettant d’ajouter un portefeuille disparaît alors de l’écran et il ne peut plus créer de nouveau portefeuille."""},

                //Ticket 12
                new Ticket{ProductVersionId=7, OSId=3, StatusId=1, CreationDate=new DateTime(2026,6,15), ResolutionDate=new DateTime(2026,6,19),
                    IssueDescription="""Les dates sont affichées dans un format américain. L’utilisateur consulte la date d’un investissement et « 04/05 » est affiché alors qu’il a investi le 5 avril.""",
                    ResolutionDescription="""L’application affiche maintenant les dates au format français : jour, mois, année."""},

                //Ticket 13
                new Ticket{ProductVersionId=7, OSId=5, StatusId=1, CreationDate=new DateTime(2026,6,27), ResolutionDate=new DateTime(2026,7,1),
                    IssueDescription="""L’utilisateur recherche un investissement en saisissant les premières lettres de son nom. Aucun résultat ne s’affiche tant qu’il n’a pas écrit le nom complet, ce qui rend la recherche longue et peu pratique.""",
                    ResolutionDescription="""La recherche exigeait le nom complet de l’investissement. Elle fonctionne désormais dès les premières lettres saisies."""},

                //Ticket 14
                new Ticket{ProductVersionId=8, OSId=1, StatusId=2, CreationDate=new DateTime(2026,7,4),
                    IssueDescription="""L’utilisateur programme une séance d’entraînement pour un dimanche. Lorsqu’il consulte son calendrier, la séance apparaît le lundi suivant, ce qui fausse l’organisation de sa semaine."""},

                //Ticket 15
                new Ticket{ProductVersionId=8, OSId=2, StatusId=1, CreationDate=new DateTime(2026,7,12), ResolutionDate=new DateTime(2026,7,13),
                    IssueDescription="""L’utilisateur crée une séance de course de 30 minutes. Après l’enregistrement, l’application affiche une durée de 30 heures, ce qui rend le programme d’entraînement incohérent.""",
                    ResolutionDescription="""Une conversion d’unité incorrecte a été corrigée dans le formulaire de création de séance."""},

                //Ticket 16
                new Ticket{ProductVersionId=9, OSId=6, StatusId=2, CreationDate=new DateTime(2026,7,12),
                    IssueDescription="""L’utilisateur consulte son calendrier mensuel sur son téléphone Windows Mobile. Les derniers jours du mois ne sont pas visibles à l’écran et il ne peut pas les atteindre en faisant défiler la page."""},

               //Ticket 17
                new Ticket{ProductVersionId=9, OSId=4, StatusId=1, CreationDate=new DateTime(2026,7,12), ResolutionDate=new DateTime(2026,7,13),
                    IssueDescription="""L’utilisateur termine une séance et la marque comme réalisée dans l’application. Malgré cela, il reçoit plus tard une notification lui rappelant cette même séance, comme s’il ne l’avait pas effectuée.""",
                    ResolutionDescription="""La tâche de notification n’était pas annulée après validation de la séance. Elle est désormais supprimée automatiquement."""},

                //Ticket 18
                new Ticket{ProductVersionId=9, OSId=5, StatusId=1, CreationDate=new DateTime(2026,7,19), ResolutionDate=new DateTime(2026,7,26),
                    IssueDescription="""Après avoir installé une mise à jour de l’application, l’utilisateur constate que les exercices qu’il avait créés lui-même ne sont plus disponibles. Il doit alors recréer manuellement tous ses exercices personnalisés.""",
                    ResolutionDescription="""La migration des données locales ne reprenait pas cette catégorie d’exercices. Le processus de migration a été corrigé."""},

                //Ticket 19
                new Ticket{ProductVersionId=10, OSId=3, StatusId=1, CreationDate=new DateTime(2026,7,23), ResolutionDate=new DateTime(2026,7,26),
                    IssueDescription="""L’utilisateur duplique un programme d’entraînement existant afin de gagner du temps. Les exercices sont bien copiés, mais les temps de récupération entre les exercices ont disparu dans le nouveau programme.""",
                    ResolutionDescription="""Le champ de récupération était exclu de la copie. Il est maintenant inclus dans les programmes dupliqués."""},

                //Ticket 20
                new Ticket{ProductVersionId=11, OSId=2, StatusId=1, CreationDate=new DateTime(2026,8,3), ResolutionDate=new DateTime(2026,8,5),
                    IssueDescription="""L’utilisateur renseigne son niveau d’anxiété après un exercice. L’application accepte la valeur 11 alors que l’échelle proposée va normalement de 0 à 10, ce qui fausse le suivi de sa progression.""",
                    ResolutionDescription="""La validation du champ était absente lors de la saisie manuelle. Une limite stricte de 0 à 10 a été ajoutée."""},

                //Ticket 21
                new Ticket{ProductVersionId=11, OSId=3, StatusId=1, CreationDate=new DateTime(2026,8,20), ResolutionDate=new DateTime(2026,8,26),
                    IssueDescription="""L’utilisateur ajoute une note après avoir réalisé un exercice d’exposition, puis ferme rapidement la fenêtre. Lorsqu’il revient consulter l’exercice, sa note a disparu et il doit la saisir une seconde fois.""",
                    ResolutionDescription="""La sauvegarde était déclenchée uniquement après un délai. Elle est désormais effectuée dès la fermeture du formulaire."""},

                //Ticket 22
                new Ticket{ProductVersionId=11, OSId=4, StatusId=1, CreationDate=new DateTime(2026,8,20), ResolutionDate=new DateTime(2026,8,23),
                    IssueDescription="""L’utilisateur active le mode sombre pour utiliser l’application dans un environnement peu éclairé. Le texte des conseils devient alors trop sombre ou trop peu contrasté, ce qui le rend difficile à lire.""",
                    ResolutionDescription="""Certaines couleurs du thème clair étaient réutilisées dans le thème sombre. Les contrastes ont été ajustés."""},

                //Ticket 23
                new Ticket{ProductVersionId=12, OSId=5, StatusId=2, CreationDate=new DateTime(2026,9,1),
                    IssueDescription="""L’utilisateur consulte son suivi hebdomadaire après avoir voyagé dans un autre fuseau horaire. Les exercices réalisés pendant la semaine ne s’affichent plus dans le récapitulatif, qui semble complètement vide."""},

                //Ticket 24
                new Ticket{ProductVersionId=12, OSId=3, StatusId=2, CreationDate=new DateTime(2026,9,3),
                    IssueDescription="""L’utilisateur imprime son bilan mensuel afin de le conserver ou de le partager. Lorsque ses commentaires sont longs, une partie du texte est coupée sur la page suivante et ne peut pas être lue."""},

                //Ticket 25
                new Ticket{ProductVersionId=9, OSId=6, StatusId=1, CreationDate=new DateTime(2026,9,3), ResolutionDate=new DateTime(2026,9,6),
                    IssueDescription="""L’utilisateur modifie la date d’une séance déjà planifiée. Après l’enregistrement, l’ancienne date continue d’apparaître dans le calendrier, ce qui lui fait croire que la modification n’a pas été prise en compte.""",
                    ResolutionDescription="""Le calendrier ne se rafraîchissait pas après la modification. Il est désormais mis à jour automatiquement."""}

            };
            await dbContext.AddRangeAsync(tickets);
            await dbContext.SaveChangesAsync();
        }
    }
}
