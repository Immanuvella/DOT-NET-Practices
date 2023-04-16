//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TelephoneInheritance
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectronicPhone a = new ElectronicPhone("Landline");
            a.Ring();
            Console.ReadKey();
        }

    }
    class Telephone
    {
        protected string PhoneType;
        public string PHoneType
        {
            get { return PhoneType; }
            set { PhoneType = value; }
        }


        public Telephone()
        {

        }
        public Telephone(string phoneType)
        {
            PhoneType = phoneType;
        }


        public void Ring()
        {
            Console.WriteLine( PhoneType+ " is Ringing");
        }

    }
    class ElectronicPhone : Telephone
    {
        public ElectronicPhone()
        {

        }
        public ElectronicPhone(string phoneType) : base(phoneType)
        {

        }
    }
}