using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зоопарк_ревьюер
{
    public class Mammals
    {
        public string Name { get; set; }

        public Mammals(string name)
        {
            Name = name;
        }

        public void Info()
        {
            Console.WriteLine("InfoMammals class of vertebrates, the most famous group of animals," +
                "including more than 4600 species of the world fauna.It includes cats," +
                "dogs, cows, elephants, mice, whales, people, etc.");
        }

    }
    
    


}
