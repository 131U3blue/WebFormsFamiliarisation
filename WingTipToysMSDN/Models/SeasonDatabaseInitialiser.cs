using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace WingTipToysMSDN.Models
{
    public class SeasonDatabaseInitialiser : DropCreateDatabaseAlways<SeasonContext>
    {
        protected override void Seed(SeasonContext context)
        {
            GetTeams().ForEach(te => context.Teams.Add(te));
            GetDrivers().ForEach(d => context.Drivers.Add(d));
            GetTracks().ForEach(tr => context.Tracks.Add(tr));
            GetProducts().ForEach(p => context.Products.Add(p));
            GetCategories().ForEach(c => context.Categories.Add(c));
        }

        private static List<Team> GetTeams()
        {
            var teams = new List<Team> {
                new Team {
                    TeamId = 1,
                    TeamName = "AMG Mercedes",
                    TeamDescription = "Daimler AG, through its Mercedes-Benz brand, has been involved in Formula One as both " +
                    "team owner and engine manufacturer for various periods since 1954. They currently own 33 percent of the team " +
                    "based in Brackley, England, which is currently named Mercedes-AMG Petronas F1 Team and uses a German licence." +
                    " Mercedes-branded teams are often referred to by their nickname, the \"Silver Arrows\". "
                },
                new Team {
                    TeamId = 2,
                    TeamName = "Red Bull Racing",
                    TeamDescription = "Red Bull Racing came into existence late in 2004 – under the guidance of Team Principal " +
                    "Christian Horner – with ambitions to challenge for race victories and world championship titles." +
                    "Over the next four seasons solid foundations were laid. The Team recruited in both quantity and quality, " +
                    "steadily expanding until it was capable of going toe-to-toe with the most illustrious names in racing."
                },
                new Team {
                    TeamId = 3,
                    TeamName = "McLaren Racing",
                    TeamDescription = "McLaren Racing Limited is a British motor racing team based at the McLaren Technology Centre " +
                    "in Woking, Surrey, England. McLaren is best known as a Formula One constructor, and is the second oldest active team, " +
                    "and second most successful Formula One team after Ferrari, having won 182 races, 12 Drivers' Championships and 8 Constructors' Championships."
                },
                new Team {
                    TeamId = 4,
                    TeamName = "Scuderia Ferrari",
                    TeamDescription = "Scuderia Ferrari is the racing division of luxury Italian auto manufacturer Ferrari and the racing team that competes " +
                    "in Formula One racing. The team is also nicknamed \"The Prancing Horse\", with reference to their logo. It is the oldest surviving and most " +
                    "successful Formula One team, having competed in every world championship since the 1950 Formula One season."
                },
                new Team {
                    TeamId = 5,
                    TeamName = "Alpha Tauri",
                    TeamDescription = "Scuderia AlphaTauri, or simply AlphaTauri, and competing as Scuderia AlphaTauri Honda, is an Italian Formula One racing team and constructor." +
                    " It is one of two Formula One constructors owned by Austrian beverage company Red Bull, the other being Red Bull Racing. " +
                    "The constructor was rebranded for the 2020 Formula One World Championship from \"Toro Rosso\" to \"AlphaTauri\" in order to promote the AlphaTauri fashion brand."
                },
                new Team {
                    TeamId = 6,
                    TeamName = "Aston Martin",
                    TeamDescription = "The Aston Martin name is back in Grand Prix racing. The Aston Martin Cognizant Formula One™ Team will make its race debut" +
                    " in Bahrain, on 28 March, marking a return to top-flight single-seater competition. We've enjoyed great success in sportscar racing in recent years," +
                    " highlighted by multiple class victories at the 24 Hours of Le Mans and now the time has come to commit to the most famous of all motorsport arenas: Formula One."
                },
                new Team {
                    TeamId = 7,
                    TeamName = "Alpine Renault",
                    TeamDescription = "Alpine F1 Team is a Formula One constructor which made its debut at the start of the 2021 Formula One World Championship. " +
                    "Formerly named Renault F1 Team and owned by the French automotive company Groupe Renault, the team was rebranded for 2021 to promote Renault's sports " +
                    "car brand, Alpine, and continues to serve as Renault's works team. The chassis and managerial side of the team is based in Enstone, Oxfordshire, England," +
                    " and the engine side of the team is based in Viry-Châtillon, a suburb of Paris, France. "
                },
                new Team {
                    TeamId = 8,
                    TeamName = "Alfa Romeo Racing",
                    TeamDescription = "Sauber Motorsport AG is a Swiss motorsport engineering company. It was founded in 1970 (as PP Sauber AG) by Peter Sauber," +
                    " who progressed through hillclimbing and the World Sportscar Championship to reach Formula One in 1993. In 2019, following a sponsorship deal," +
                    " Sauber Motorsport AG renamed their Formula One racing team to Alfa Romeo Racing after operating it under their own name from 1993 until 2018. "
                },
                new Team {
                    TeamId = 9,
                    TeamName = "Haas",
                    TeamDescription = "Haas Formula LLC, competing as Uralkali Haas F1 Team, is an American Formula One racing team established by " +
                    "NASCAR Cup Series team co-owner Gene Haas in April 2014. The team originally intended to make its debut at the start of the 2015 season " +
                    "but later elected to postpone their entry until the 2016 season. The team principal for the Haas F1 team is Guenther Steiner. "
                },
                new Team {
                    TeamId = 10,
                    TeamName = "Williams",
                    TeamDescription = "Williams Grand Prix Engineering Limited, currently racing in Formula One as Williams Racing, is a British Formula One" +
                    " motor racing team and constructor. It was founded by former team owner Frank Williams and automotive engineer Patrick Head. " +
                    "The team was formed in 1977 after Frank Williams's earlier unsuccessful F1 operation: Frank Williams Racing Cars (which later became Wolf–Williams Racing in 1976)." +
                    " All of Williams F1 chassis are called \"FW\" then a number, the FW being the initials of team co-founder and original owner, Frank Williams. "
                }
            };

            return teams;
        }

        private static List<Driver> GetDrivers()
        {
            var drivers = new List<Driver> {
                new Driver {
                    DriverId = 1,
                    DriverName = "Lewis Hamilton",
                    ImagePath = "images/drivers/HAM.jpg",
                    Nationality = "British",
                    RaceStarts = 272,
                    Wins = 98,
                    Podiums = 169,
                    HighestFinish = 1,
                    WorldChampionships = 7,
                    TeamId = 1,
                },
                new Driver {
                    DriverId = 2,
                    DriverName = "Valtteri Bottas",
                    ImagePath = "images/drivers/BOT.jpg",
                    Nationality = "Finnish",
                    RaceStarts = 163,
                    Wins = 9,
                    Podiums = 59,
                    HighestFinish = 1,
                    WorldChampionships = 0,
                    TeamId = 1
                },
                new Driver {
                    DriverId = 3,
                    DriverName = "Max Verstappen",
                    ImagePath = "images/drivers/VER.jpg",
                    Nationality = "Dutch",
                    RaceStarts = 125,
                    Wins = 12,
                    Podiums = 47,
                    HighestFinish = 1,
                    WorldChampionships = 0,
                    TeamId = 2
                },
                new Driver {
                    DriverId = 4,
                    DriverName = "Sergio Perez",
                    ImagePath = "images/drivers/PER.jpg",
                    Nationality = "Mexican",
                    RaceStarts = 199,
                    Wins = 2,
                    Podiums = 11,
                    HighestFinish = 1,
                    WorldChampionships = 0,
                    TeamId = 2
                },
                new Driver {
                    DriverId = 5,
                    DriverName = "Lando Norris",
                    ImagePath = "images/drivers/NOR.jpg",
                    Nationality = "British",
                    RaceStarts = 44,
                    Wins = 0,
                    Podiums = 3,
                    HighestFinish = 3,
                    WorldChampionships = 0,
                    TeamId = 3
                },
                new Driver {
                    DriverId = 6,
                    DriverName = "Daniel Riccardo",
                    ImagePath = "images/drivers/RIC.jpg",
                    Nationality = "Australian",
                    RaceStarts = 194,
                    Wins = 7,
                    Podiums = 31,
                    HighestFinish = 1,
                    WorldChampionships = 0,
                    TeamId = 3
                },
                new Driver {
                    DriverId = 7,
                    DriverName = "Charles Leclerc",
                    ImagePath = "images/drivers/LEC.jpg",
                    Nationality = "Monacan",
                    RaceStarts = 65,
                    Wins = 1,
                    Podiums = 12,
                    HighestFinish = 1,
                    WorldChampionships = 0,
                    TeamId = 4
                },
                new Driver {
                    DriverId = 8,
                    DriverName = "Carlos Sainz",
                    ImagePath = "images/drivers/SAI.jpg",
                    Nationality = "Spanish",
                    RaceStarts = 125,
                    Wins = 0,
                    Podiums = 3,
                    HighestFinish = 2,
                    WorldChampionships = 0,
                    TeamId = 4
                },
                new Driver {
                    DriverId = 9,
                    DriverName = "Pierre Gasly",
                    ImagePath = "images/drivers/GAS.jpg",
                    Nationality = "French",
                    RaceStarts = 70,
                    Wins = 1,
                    Podiums = 3,
                    HighestFinish = 1,
                    WorldChampionships = 0,
                    TeamId = 5
                },
                new Driver {
                    DriverId = 10,
                    DriverName = "Yuki Tsunoda",
                    ImagePath = "images/drivers/TSU.jpg",
                    Nationality = "Japanese",
                    RaceStarts = 6,
                    Wins = 0,
                    Podiums = 0,
                    HighestFinish = 7,
                    WorldChampionships = 0,
                    TeamId = 5
                },
                new Driver {
                    DriverId = 11,
                    DriverName = "Sebastian Vettel",
                    ImagePath = "images/drivers/VET.jpg",
                    Nationality = "German",
                    RaceStarts = 264,
                    Wins = 53,
                    Podiums = 122,
                    HighestFinish = 1,
                    WorldChampionships = 4,
                    TeamId = 6
                },
                new Driver {
                    DriverId = 12,
                    DriverName = "Lance Stroll",
                    ImagePath = "images/drivers/STR.jpg",
                    Nationality = "Canadian",
                    RaceStarts = 84,
                    Wins = 0,
                    Podiums = 3,
                    HighestFinish = 3,
                    WorldChampionships = 0,
                    TeamId = 6
                },
                new Driver {
                    DriverId = 13,
                    DriverName = "Fernando Alonso",
                    ImagePath = "images/drivers/ALO.jpg",
                    Nationality = "Spanish",
                    RaceStarts = 320,
                    Wins = 32,
                    Podiums = 97,
                    HighestFinish = 1,
                    WorldChampionships = 2,
                    TeamId = 7
                },
                new Driver {
                    DriverId = 14,
                    DriverName = "Esteban Ocon",
                    ImagePath = "images/drivers/OCO.jpg",
                    Nationality = "French",
                    RaceStarts = 73,
                    Wins = 0,
                    Podiums = 1,
                    HighestFinish = 2,
                    WorldChampionships = 0,
                    TeamId = 7
                },
                new Driver {
                    DriverId = 15,
                    DriverName = "Antonio Giovinazzi",
                    ImagePath = "images/drivers/GIO.jpg",
                    Nationality = "Italian",
                    RaceStarts = 46,
                    Wins = 0,
                    Podiums = 0,
                    HighestFinish = 5,
                    WorldChampionships = 0,
                    TeamId = 8
                },
                new Driver {
                    DriverId = 16,
                    DriverName = "Kimi Raikkonen",
                    ImagePath = "images/drivers/RAI.jpg",
                    Nationality = "Finnish",
                    RaceStarts = 338,
                    Wins = 21,
                    Podiums = 103,
                    HighestFinish = 1,
                    WorldChampionships = 1,
                    TeamId = 8
                },
                new Driver {
                    DriverId = 17,
                    DriverName = "Mick Schumacher",
                    ImagePath = "images/drivers/MSC.jpg",
                    Nationality = "German",
                    RaceStarts = 6,
                    Wins = 0,
                    Podiums = 0,
                    HighestFinish = 17,
                    WorldChampionships = 0,
                    TeamId = 9
                },
                new Driver {
                    DriverId = 18,
                    DriverName = "Nikita Mazepin",
                    ImagePath = "images/drivers/MAZ.jpg",
                    Nationality = "Russian",
                    RaceStarts = 6,
                    Wins = 0,
                    Podiums = 0,
                    HighestFinish = 18,
                    WorldChampionships = 0,
                    TeamId = 9
                },
                new Driver {
                    DriverId = 19,
                    DriverName = "George Russell",
                    ImagePath = "images/drivers/RUS.jpg",
                    Nationality = "British",
                    RaceStarts = 44,
                    Wins = 0,
                    Podiums = 0,
                    HighestFinish = 9,
                    WorldChampionships = 0,
                    TeamId = 10
                },
                new Driver {
                    DriverId = 20,
                    DriverName = "Nicholas Latifi",
                    ImagePath = "images/drivers/LAT.jpg",
                    Nationality = "Canada",
                    RaceStarts = 23,
                    Wins = 0,
                    Podiums = 0,
                    HighestFinish = 11,
                    WorldChampionships = 0,
                    TeamId = 10
                }
            };

            return drivers;
        }

        private static List<Track> GetTracks()
        {
            var tracks = new List<Track> {
                new Track {
                    TrackId = 1,
                    TrackName = "Bahrain International Circuit",
                    Country = "Bahrain",
                    RaceDate = new DateTime(2021, 3, 28)
                },
                new Track {
                    TrackId = 2,
                    TrackName = "Emilia Romagna",
                    Country = "Italy",
                    RaceDate = new DateTime(2021, 4, 18)
                },
                new Track {
                    TrackId = 3,
                    TrackName = "Algarve International Circuit",
                    Country = "Portugal",
                    RaceDate = new DateTime(2021, 5, 2)
                },
                new Track {
                    TrackId = 4,
                    TrackName = "Cicuit De Barcelona-Catalunya",
                    Country = "Spain",
                    RaceDate = new DateTime(2021, 5, 9)
                },
                new Track {
                    TrackId = 5,
                    TrackName = "Circuit De Monaco",
                    Country = "Monaco",
                    RaceDate = new DateTime(2021, 5, 23)
                },
                new Track {
                    TrackId = 6,
                    TrackName = "Baku City Circuit",
                    Country = "Azerbaijan",
                    RaceDate = new DateTime(2021, 6, 6)
                },
                new Track {
                    TrackId = 7,
                    TrackName = "Circuit Gilles Villeneuve",
                    Country = "Canada",
                    RaceDate = new DateTime(2021, 6, 13)
                },
                new Track {
                    TrackId = 8,
                    TrackName = "Cicuit Paul Ricard",
                    Country = "France",
                    RaceDate = new DateTime(2021, 6, 20)
                },
                new Track {
                    TrackId = 9,
                    TrackName = "Red Bull Ring",
                    Country = "Austria",
                    RaceDate = new DateTime(2021, 6, 27)
                },
                new Track {
                    TrackId = 10,
                    TrackName = "Red Bull Ring",
                    Country = "Austria",
                    RaceDate = new DateTime(2021, 7, 4)
                },
                new Track {
                    TrackId = 11,
                    TrackName = "Silverstone",
                    Country = "Britain",
                    RaceDate = new DateTime(2021, 7, 18)
                },
                new Track {
                    TrackId = 12,
                    TrackName = "Hungaroring",
                    Country = "Hungary",
                    RaceDate = new DateTime(2021, 8, 1)
                },
                new Track {
                    TrackId = 13,
                    TrackName = "Spa-Francorchamps",
                    Country = "Belgium",
                    RaceDate = new DateTime(2021, 8, 29)
                },
                new Track {
                    TrackId = 14,
                    TrackName = "Circuit Zandvoort",
                    Country = "Netherlands",
                    RaceDate = new DateTime(2021, 9, 5)
                },
                new Track {
                    TrackId = 15,
                    TrackName = "Monza",
                    Country = "Italy",
                    RaceDate = new DateTime(2021, 9, 12)
                },
                new Track {
                    TrackId = 16,
                    TrackName = "Sochi Autodrom",
                    Country = "Russia",
                    RaceDate = new DateTime(2021, 9, 26)
                },
                new Track {
                    TrackId = 17,
                    TrackName = "Suzuka",
                    Country = "Japan",
                    RaceDate = new DateTime(2021, 10, 10)
                },
                new Track {
                    TrackId = 18,
                    TrackName = "Circuit Of The Americas",
                    Country = "United States",
                    RaceDate = new DateTime(2021, 10, 24)
                },
                new Track {
                    TrackId = 19,
                    TrackName = "Hermanos Rodriguez",
                    Country = "Mexico",
                    RaceDate = new DateTime(2021, 10, 31)
                },
                new Track {
                    TrackId = 20,
                    TrackName = "Jose Carlos Pace",
                    Country = "Brazil",
                    RaceDate = new DateTime(2021, 11, 7)
                },
                new Track {
                    TrackId = 21,
                    TrackName = "Melbourne GP Circuit",
                    Country = "Australia",
                    RaceDate = new DateTime(2021, 11, 21)
                },
                new Track {
                    TrackId = 22,
                    TrackName = "Jeddah Street Circuit",
                    Country = "Saudi Arabia",
                    RaceDate = new DateTime(2021, 12, 5)
                },
                new Track {
                    TrackId = 23,
                    TrackName = "Yas Marina Circuit",
                    Country = "Abu Dhabi",
                    RaceDate =  new DateTime(2021, 12, 12)
                }
            };
            return tracks;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product>() {
                new Product {
                    ProductId = 1,
                    ProductName = "Miami Tee",
                    ProductPrice = 35.00,
                    CategoryId = 1,
                    ImagePath = "images/merch/miamiTee.jpg",
                    ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
                },
                new Product {
                    ProductId = 2,
                    ProductName = "White Tee",
                    ProductPrice = 28.00,
                    CategoryId = 1,
                    ImagePath = "images/merch/whiteTee.jpg",
                    ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
                },
                new Product {
                    ProductId = 3,
                    ProductName = "Miami Hoodie",
                    ProductPrice = 56.00,
                    CategoryId = 2,
                    ImagePath = "images/merch/miamiHoodie.jpg",
                    ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
                }
            };
            return products;
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category>() {
                new Category {
                    CategoryId = 1,
                    CategoryName = "T-Shirts"
                },
                new Category {
                    CategoryId = 2,
                    CategoryName = "Hoodies"
                }
            };
            return categories;
        }
    }
}