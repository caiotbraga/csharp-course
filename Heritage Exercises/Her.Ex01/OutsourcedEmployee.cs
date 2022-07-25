using System.Text;
using System.Globalization;
namespace Her_Ex01.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return (ValuePerHour * Hours) + (AdditionalCharge * 1.1);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" - $ ");
            sb.Append(Payment().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
