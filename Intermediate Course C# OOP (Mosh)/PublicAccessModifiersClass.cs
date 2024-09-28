using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    public class PublicAccessModifiersClass
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating();
            if (rating == 0)
                Console.WriteLine("Promoted to Lvl 1");
            else
                Console.WriteLine("Promoted to Lvl 2");
        }

        public int CalculateRating()
        {
            return 0;
        }
    }
}
