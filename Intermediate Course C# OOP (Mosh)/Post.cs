using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_ 
{
    internal class Post
    {
        public string Tittle { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; private set; }
        public int Vote { get; private set; }
        private int _vote = 0;
            
        public int GetVoteCounts 
        { 
            get
            {
                return _vote;
            }
        }
        public int UpVote()
        {
            _vote++;
            //CreatePost();
            return _vote;
        }

        public int DownVote()
        {
            _vote--;
            //CreatePost();
            return _vote;
        }
        public void CreatePost()
        {
            Console.WriteLine("Please enter the tittle: ");
            Tittle = Console.ReadLine();
            Console.WriteLine("Please enter the description on the tittle: ");
            Description = Console.ReadLine();
            DateTime = DateTime.Now;
            //Vote = 0;

            Console.WriteLine("Tittle: {0}",Tittle);
            Console.WriteLine("Description: {0}",Description);
            Console.WriteLine(DateTime);
            Console.WriteLine("Vote: {0}",_vote);
        }
    }
}
