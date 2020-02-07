using System;
using System.Collections.Generic;
using System.Text;
using Composition3.Entitites.Enum;

namespace Composition3.Entitites
{
    class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus orderStatus { get; set; }
    }
}
