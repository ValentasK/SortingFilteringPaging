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
                    HouseNr = randomNumber.Next(0, 350).ToString()

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
                "Winifred", "Ronda" };

        List<string> surnames = new List<string>() { "Kelley", "Carter", "Salazar", "Osborne", "Santiago",
                "Luna", "Wilson", "Craig", "Willis", "Frank", "Johnson", "Cunningham", "Rice", "Carter", "Lloyd",
                "Bryant", "Sawyer", "Barton", "Butler", "Taylor", "Burgess", "Harper", "Peters", "Steele", "Rodriguez",
                "Flores", "Bass", "Brewer", "Graves", "Morrison", "Craig", "Ayala", "Tate", "Park", "Campbell", "Love",
                "Horton", "Palmer", "Marsh", "Knowles", "Carroll", "Cartwright", "Francis", "Schneider", "Clarke", "Reyes",
                "Hammond", "Perkins", "Hampton", "Hardy" };

        List<string> gender = new List<string>() { "Male", "Female" };

        List<string> cities = new List<string>() { "Priest River", "Eton ", "Dothan", "Valparaiso", "Culver City",
                "Yeppoon", "Concord", "Martinez","Eveleth","Hull","Winsford","Huron","Cranbrook","Woburn Sands","Edinburg"};

        List<string> streets = new List<string>() { "Bay Retreat", "Peartree Drift", "Austen Top", "Cranbrook Head",
                "Colliers Maltings", "Austen Manor", "Birchfield Woods", "Swiss Road", "Yarrow Head", "Howden Approach",
                "Mount Hermon Close", "Maes Dolwen", "Cranbrook Wharf", "Westminster Approach", "Castleton Highway", };

    }
}
