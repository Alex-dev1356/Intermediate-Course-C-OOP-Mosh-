using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_.StockOverflow_Post_Exercise
{
    public class StockOverflowPostClass
    {
        public string title { get; set; }
        public string description { get; set; }
        public DateTime dateCreated { get; set; }
        public int currentVote { get; private set; }   

        //private readonly List<StockOverflowPostClass> listOfBooks = new List<StockOverflowPostClass>();
        public List<StockOverflowPostClass> listOfBooks = new List<StockOverflowPostClass>();

        public StockOverflowPostClass()
        {
            currentVote = 0;
        }
        public void upVote()
        {
            currentVote++;
            //Console.WriteLine("The current vote: {0}", currentVote); 
        }

        public void downVote()
        {
            currentVote--;
            //Console.WriteLine("The current vote: {0}", currentVote);
        }

        public void AddPost(StockOverflowPostClass post)
        {
            listOfBooks.Add(post);
        }

        public List<StockOverflowPostClass> GetPosts()
        {
            return listOfBooks;
        }

    }
}
