using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    //We will deriving this Text Class to the Shape Class
    public class DerivedClassText_UpAndDownCasting : BaseClassShape_UpAndDownCasting
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }    
    }
}
