using System;
using Enum_Ex01.Entities.Enums;

namespace Enum_Ex01.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return "Id:" 
                + Id
                + ","
                + Moment
                + ","
                + Status;
        }
    }
}
