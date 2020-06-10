using SortingFilteringPaging.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortingFilteringPaging.Data
{
    public class SeedData
    {
        public List<Customer> GeneratedCustomers(int numberOfCustomers)
        {
            Random randomNumber = new Random();  // create new random object

            List<Customer> customers = new List<Customer>(); // create list of customers

            for (int i = 0; i < numberOfCustomers; i++) // every time loop creates new customer with random details 
            {
                customers.Add(new Customer()
                {
                    FirstName = names[randomNumber.Next(0,names.Count)],
                    LastName = surnames[randomNumber.Next(0,surnames.Count)],
                    MaleFemale = gender[randomNumber.Next(0,gender.Count)],
                    Age = randomNumber.Next(16,110),
                    PhoneNumber = RandomDigits(8),
                    EmailAddress = names[randomNumber.Next(0, names.Count)] + randomNumber.Next(1,99999)+"@gmail.com",
                    City = cities[randomNumber.Next(0, cities.Count)],
                    Street = streets[randomNumber.Next(0, streets.Count)],
                    HouseNr = randomNumber.Next(1, 350).ToString()

                });
            }
            return customers;
        }

        private string RandomDigits(int length)  // generates phone number 
        {
            var random = new Random();
            string s = "07";
            for (int i = 0; i < length; i++)
                s = String.Concat(s, random.Next(10).ToString());
            return s;
        }

        List<string> names = new List<string>() { "Chi", "Brent", "Keenan", "Jerome", "Victor",
                "Jared", "Shad", "Romeo", "Francis", "Patrick", "Murray", "Jody", "Billie", "Tory",
                "Haywood", "Stanford", "Kurtis", "Steven", "Garry", "Reginald", "Darcel", "Neida",
                "Malinda", "Ping", "Ashlyn", "Harriet", "Santina", "Vernie", "Evelina", "Katrina",
                "Rema", "Marge", "Rolande", "Shae", "Dina", "Lucretia", "Malka", "Eustolia", "Mandi",
                "Joannie", "Chu", "Sindy", "Concha", "Arminda", "Latoyia", "Leola", "Ursula", "Margherita",
                "Winifred", "Ronda","Ralphie","Shamima","Anisah","Gail","Cherie","Danielius","Harper","Malachi",
                "Leoni","Lilly-Mai","Samah","Sahib","Tyrese","Aiesha","Kaitlyn","Umar","Enya","Ray","Isaac","Jordi",
                "Cecilia","Helin","Maiya","Gwion","Ibrar","Shereen","Zakariyah","Keely","Meg","Teodor","Ammar","Calista",
                "Eduardo","Priya","Waqar","Nicholas","Donald","Colin","Jasper","Kerrie","Mared","Marion","Hisham","Adem",
                "Jamie-Lee","Belle","Bobbi","Avneet","Blaine","Stephen","Stuart","Kyal","Edmund","Theresa","Findlay",
                "Ruby-Rose","Maaria","Kacper","Philippa","Katarina","Esme-Rose","Zishan","Brody","Kia","Dylan","Wil",
                "Khadeeja","Presley","Lia","Raisa","Ashlyn","Harlee","Maurice","Goulding","Alishia","Misha","Matilda",
                "Danyaal","Nikita","Macy","Gus","Lacy","Rudi","Tyrell","Kaylen","Diana","Cillian","Viktor","Valode",
                "Kestas","Kestutis","Aurimas","Mantas","Paulius","Milda","Daiva","Gita","Loreta","Viktorija","Gedas",
                "Tomas","Augutis","Greta","Karolis","Karolina","Viktoras","Vale","Lilly","Milli","Bella","Maddison",
                "Caitlin","Safiyyah","Agnes","Kiaan","Tai","Evan","Davina","Harleigh","Jolene"};

        List<string> surnames = new List<string>() { "Kelley", "Carter", "Salazar", "Osborne", "Santiago",
                "Luna", "Wilson", "Craig", "Willis", "Frank", "Johnson", "Cunningham", "Rice", "Carter", "Lloyd",
                "Bryant", "Sawyer", "Barton", "Butler", "Taylor", "Burgess", "Harper", "Peters", "Steele", "Rodriguez",
                "Flores", "Bass", "Brewer", "Graves", "Morrison", "Craig", "Ayala", "Tate", "Park", "Campbell", "Love",
                "Horton", "Palmer", "Marsh", "Knowles", "Carroll", "Cartwright", "Francis", "Schneider", "Clarke", "Reyes",
                "Hammond", "Perkins", "Hampton", "Hardy","England","Connelly","Berna","Haworth","Mueller","Orr","Kim","Costa",
                "Davila","Ventura","Barron","Morton","Cannon","Parry","Forrest","Rich","Good","Denton","Wells","Dunn","Sharp",
                "Merritt","Berry","Salas","Torres","Ramsay","Hull","Murphy","Naylor","Houghton","Bowden","Beck","Emery","Wilde",
                "Reyna","Sharples","Welch","Storey","Duke","Finley","Baldwin","Macleod","Pugh","Keller","Williams","Bowler","Sharpe",
                "Dawe","Kennedy","Sadler","Villalobos","Hooper","Beasley","Keenan","Larsen","Couch","Glenn","Wolfe","Hurst","Stark",
                "Frederick","Benton","Vance","Morrison","Puckett","Griffin","Woodley","Person","Hutchings","Mejia","Whitfield","Jones",
                "Thatcher","Dorsey","Leblanc","Glover","Lewis","Mercer","Weeks","Booker","Higgins","Beaumont","Mclaughlin","Pennington",
                "Easton","Mercado","Chase","Pritchard","Bullock"," Whitworth","Maldonado","Anderson","Clegg","Sheridan","Kidd","Miles",
                "Vargas","Barker","Horton"};

        List<string> gender = new List<string>() { "Male", "Female" };

        List<string> cities = new List<string>() { "Priest River", "Eton ", "Dothan", "Valparaiso", "Culver City",
                "Yeppoon", "Concord", "Martinez","Eveleth","Hull","Winsford","Huron","Cranbrook","Woburn Sands","Edinburg"};

        List<string> streets = new List<string>() { "Bay Retreat", "Peartree Drift", "Austen Top", "Cranbrook Head",
                "Colliers Maltings", "Austen Manor", "Birchfield Woods", "Swiss Road", "Yarrow Head", "Howden Approach",
                "Mount Hermon Close", "Maes Dolwen", "Cranbrook Wharf", "Westminster Approach", "Castleton Highway", };

    }
}
