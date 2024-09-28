using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    internal class AccessModifiers
    {
        //When declaring Fields, we should NOT DECLARE THEM PUBLIC BUT RATHER PRIVATE, AND PROVIDE SOME
        //METHODS THAT WOULD GIVE ACCESS TO THOSE FIELDS AND THESE METHODS ARE THE GETTERS AND SETTERS.
        //IN WHICH THIS METHODS ARE DECLARED AS PUBLIC. This is the example of those methods and fields.

        //This is the right way in creating a field, it SHOULD BE SET TO PRIVATE AND STARTS WITH '_' and 
        //Camel Case.
        private string _name;
        private DateTime _birthdate;

        public void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name))
                _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;

        }

    }
}
