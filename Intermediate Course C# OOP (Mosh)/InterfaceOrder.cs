using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    public class InterfaceOrder
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public InterfaceShipment Shipment { get; set; }
        public float TotalPrice { get; set; }

        public bool IsShipped 
        {
            get { return Shipment != null; }
        }
    }
}
