using System;
using System.Runtime.Serialization;

namespace CarPoolingSystemReq1
{
    [Serializable]
    internal class InvalidEmailException : Exception
    {

        string email;

        public InvalidEmailException()

        {

        }

        public InvalidEmailException(string email)

        {

            this.email = email;

        }

        public void inform()

        {

            Console.WriteLine("invalid mailid");

        }
    }
}