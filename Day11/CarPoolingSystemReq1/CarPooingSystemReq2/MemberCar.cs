using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingSystemReq1
{
    class MemberCar
    {
        private long _id;
        public long Id
        { 
            get { return _id; }
            set { _id = value; }
        }
        private Member _member;
        public Member Member 
        { 
            get { return _member; } 
            set { _member = value; }
        }
        private Car _car;
        public Car Car 
        { 
            get { return _car; } 
            set { _car = value; } 
        }
        private string _carRegistrationNumber;
        public string CarRegistrationNumbe
        { 
            get { return _carRegistrationNumber; }
            set { _carRegistrationNumber = value; }
        }
        private string _carColour;
        public string CarColour 
        { 
            get { return _carColour; }
            set { _carColour = value; }
        }
        public MemberCar() 
        { 
        }
        public MemberCar(long _id, Member _member, Car _car, string _carRegistrationNumbe, string _carColour)
        {
            Id = _id;
            
            Member = _member;
            
            Car = _car;
            
            CarRegistrationNumbe = _carRegistrationNumber;
            
            CarColour = _carColour;
        }
    }
}
