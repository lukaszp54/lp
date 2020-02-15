using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamFileReader();
            var people = reader.ReadPeople("data.txt");
            var sortedPeople = people.OrderBy(x => x.LastName).ThenBy(x => x.Name);

            foreach (var person in sortedPeople)
            {
                Console.WriteLine($"{person.Name} {person.LastName}");
            }

            Writer writer = new Writer();

            
            writer.WriteToFile(sortedPeople.First(), "result.txt");
            writer.WritePhoneNumbers(sortedPeople, "numbers.txt");
            writer.WriteTenPhoneNumbersToFile(sortedPeople);
            writer.WriteLetters(sortedPeople);
        }
    }
}
