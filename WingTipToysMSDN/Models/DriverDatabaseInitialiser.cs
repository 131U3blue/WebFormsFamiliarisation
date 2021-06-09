using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace WingTipToysMSDN.Models
{
    public class DriverDatabaseInitialiser : DropCreateDatabaseAlways<DriverContext>
    {
        protected override void Seed(DriverContext context)
        {
            GetTeams().ForEach(t => context.Teams.Add(t));
            GetDrivers().ForEach(d => context.Drivers.Add(d));
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
                    ImagePath = "images/HAM.jpg",
                    Nationality = "British",
                    TeamId = 1,
                },
                new Driver {
                    DriverId = 2,
                    DriverName = "Valtteri Bottas",
                    ImagePath = "images/BOT.jpg",
                    Nationality = "Finnish",
                    TeamId = 1
                },
                new Driver {
                    DriverId = 3,
                    DriverName = "Max Verstappen",
                    ImagePath = "images/VER.jpg",
                    Nationality = "Dutch",
                    TeamId = 2
                },
                new Driver {
                    DriverId = 4,
                    DriverName = "Sergio Perez",
                    ImagePath = "images/PER.jpg",
                    Nationality = "Mexican",
                    TeamId = 2
                },
                new Driver {
                    DriverId = 5,
                    DriverName = "Lando Norris",
                    ImagePath = "images/NOR.jpg",
                    Nationality = "British",
                    TeamId = 3
                },
                new Driver {
                    DriverId = 6,
                    DriverName = "Daniel Riccardo",
                    ImagePath = "images/RIC",
                    Nationality = "Australian",
                    TeamId = 3
                },
                new Driver {
                    DriverId = 7,
                    DriverName = "Charles Leclerc",
                    ImagePath = "images/LEC.jpg",
                    Nationality = "Monacan",
                    TeamId = 4
                },
                new Driver {
                    DriverId = 8,
                    DriverName = "Carlos Sainz",
                    ImagePath = "images/SAI.jpg",
                    Nationality = "Spanish",
                    TeamId = 4
                },
                new Driver {
                    DriverId = 9,
                    DriverName = "Pierre Gasly",
                    ImagePath = "images/GAS.jpg",
                    Nationality = "French",
                    TeamId = 5
                },
                new Driver {
                    DriverId = 10,
                    DriverName = "Yuki Tsunoda",
                    ImagePath = "images/TSU.jpg",
                    Nationality = "Japanese",
                    TeamId = 5
                },
                new Driver {
                    DriverId = 11,
                    DriverName = "Sebastian Vettel",
                    ImagePath = "images/VET.jpg",
                    Nationality = "German",
                    TeamId = 6
                },
                new Driver {
                    DriverId = 12,
                    DriverName = "Lance Stroll",
                    ImagePath = "images/STR.jpg",
                    Nationality = "Canadian",
                    TeamId = 6
                },
                new Driver {
                    DriverId = 13,
                    DriverName = "Fernando Alonso",
                    ImagePath = "images/ALO.jpg",
                    Nationality = "Spanish",
                    TeamId = 7
                },
                new Driver {
                    DriverId = 14,
                    DriverName = "Esteban Ocon",
                    ImagePath = "images/OCO.jpg",
                    Nationality = "French",
                    TeamId = 7
                },
                new Driver {
                    DriverId = 15,
                    DriverName = "Antonio Giovinazzi",
                    ImagePath = "images/GIO.jpg",
                    Nationality = "Italian",
                    TeamId = 8
                },
                new Driver {
                    DriverId = 16,
                    DriverName = "Kimi Raikkonen",
                    ImagePath = "images/RAI.jpg",
                    Nationality = "Finnish",
                    TeamId = 8
                },
                new Driver {
                    DriverId = 17,
                    DriverName = "Mick Schumacher",
                    ImagePath = "images/MSC.jpg",
                    Nationality = "German",
                    TeamId = 9
                },
                new Driver {
                    DriverId = 18,
                    DriverName = "Nikita Mazepin",
                    ImagePath = "images/MAZ.jpg",
                    Nationality = "Russian",
                    TeamId = 9
                },
                new Driver {
                    DriverId = 19,
                    DriverName = "George Russell",
                    ImagePath = "images/RUS.jpg",
                    Nationality = "British",
                    TeamId = 10
                },
                new Driver {
                    DriverId = 20,
                    DriverName = "Nicholas Latifi",
                    ImagePath = "images/LAT.jpg",
                    Nationality = "Canada",
                    TeamId = 10
                }
            };

            return drivers;
        }
    }
}