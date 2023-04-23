using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingSystemReq1
{
    class Member
    {
        private long _id;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _firstname;
        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        private string _lastname;
        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _contactNumber;
        public string ContactNumber
        {
            get { return _contactNumber; }
            set { _contactNumber = value; }
        }
        private string _licenceNumber;
        public string LicenceNumber
        {
            get { return _licenceNumber; }
            set { _licenceNumber = value; }
        }
        private DateTime _liceneceStartDate;
        public DateTime LiceneceStartDate
        {
            get { return _liceneceStartDate; }
            set { _liceneceStartDate = value; }
        }
        private DateTime _licenceExpiryDate;
        public DateTime LicenceExpiryDate
        {
            get { return _licenceExpiryDate; }
            set { _licenceExpiryDate = value; }
        }

        public Member()
        {

        }
        public Member(long _id, string _firstname, string _lastname, string _email, string _contactNumber, string _licenceNumber, DateTime _liceneceStartDate,DateTime _licenceExpiryDate)
        {
            Id = _id;
            FirstName = _firstname;
           
            LastName = _lastname;
            
            Email = _email;
           
            ContactNumber = _contactNumber;
            
            LicenceNumber = _licenceNumber;
            
            LiceneceStartDate = _liceneceStartDate;
            
            LicenceExpiryDate = _licenceExpiryDate;
            
        }
        public override string ToString() 
        {
            return String.Format($"Member:{_firstname},{_lastname}\n"+
                $"Member contact details:{ _contactNumber},{_email}");
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Member member = (Member)obj;
            return Email.ToLower() == member.Email.ToLower() && ContactNumber.ToLower() == member.ContactNumber.ToLower();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
