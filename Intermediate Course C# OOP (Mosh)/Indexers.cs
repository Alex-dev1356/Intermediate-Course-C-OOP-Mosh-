using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    internal class Indexers
    {
        //We will be using a Dictionary that resides in the System.Collections.Generic and IT USES A HASH
        //TABLE TO STORE DATA
        //IMPORTANT NOTE: If you have a LIST OF OBJECTS and you want to look them up BY KEY AS OPPOSED TO 
        //INDEX it is better to use a DICTIONARY, BUT if you want to look them up BY INDEX you should use
        //INDEX

        //Declaring a DICTIONANRY and INSTATIATING IT.
        //In this case the parameters in the Dictionary<string, string> means that the first string is the 
        //Data Type of KEY, and the second string parameter is the Data Type of the VALUE.
        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();

        //Declaring an Indexer
        //Note: We need to use the 'this[]' keyword in declaring a dictionary,
        //ACCESS MODIFER, RETURN TYPE, inside the this[] keyword we need to specify the data type of
        //our key value pair
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}
