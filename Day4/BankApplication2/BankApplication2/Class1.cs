using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication2
{
    public class Locker
    {
        private int _number { get; set; }
        private string _lockType { get; set; }
        private string _password { get; set; }
        private double _amount { get; set; }
        private DateTime _lastOpened { get; set; }
        public Locker()
        {

        }
        public Locker(int _number, string _lockType, string _password, double _amount, DateTime _lastOpened)
        {
            this._number = _number;
            this._lockType = _lockType;
            this._password = _password;
            this._amount = _amount;
            this._lastOpened = _lastOpened;
        }

        public static Locker CreateLocker(string detail)
        {
            string[] details = detail.Split(',');
            int _number = int.Parse(details[0]);
            string _lockType = details[1];
            string _password = details[2];

            double _amount = double.Parse(details[3]);
            DateTime _lastOpened = DateTime.Parse(details[4]);
            return new Locker(_number, _lockType, _password, _amount, _lastOpened);
        }    }
}
