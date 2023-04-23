using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingSystemReq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Member> ls = new List<Member>();
            for(int i=0;i<2;i++)
            {
                Console.WriteLine("Member {0}",i+1);

                Console.WriteLine("Id:");
                int id=int.Parse( Console.ReadLine() );

                Console.WriteLine("first name:");
                string firstname=Console.ReadLine();

                Console.WriteLine("last name:");
                string lastname=Console.ReadLine();

                Console.WriteLine("email:");
                string email=Console.ReadLine();

                Console.WriteLine("contact number:");
                string contactnumber=Console.ReadLine();

                Console.WriteLine("licence number:");
                string licencenumber=Console.ReadLine();

                Console.WriteLine("licence start date:");
                DateTime licenceStart=DateTime.ParseExact( Console.ReadLine(),"dd-mm-yyyy",null );

                Console.WriteLine("licence enddate:");
                DateTime licenceend= DateTime.ParseExact( Console.ReadLine(),"dd-mm-yyyy",null );   
                Member m1=new Member(id,firstname,lastname,email,contactnumber,licencenumber,licenceStart,licenceend);
                ls.Add(m1);
            }
            foreach(Member m in ls) 
            {
                Console.WriteLine(m.ToString());
            }
            if (ls[0].Equals(ls[1]))
            {
                Console.WriteLine("Member is same as Member 2");
            }
            else
            {
                Console.WriteLine("Member 1 and Member 2 are different");
            }
        }
    }
}
