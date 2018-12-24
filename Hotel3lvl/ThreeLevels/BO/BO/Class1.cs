using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Contact
    {
        private int _ContactId;
        private string _OwnerId;
        private string _Name;
        private string _Address;
        private string _City;
        private string _State;
        private string _Zip;
        private string _Email;
        private int _Status;

        public int contactId
        {
            get { return _ContactId; }
            set { _ContactId = value; }
        }

        public string ownerId
        {
            get { return _OwnerId; }
            set { _OwnerId = value; }
        }

        public string name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public string city
        {
            get { return _City; }
            set { _City = value; }
        }

        public string state
        {
            get { return _State; }
            set { _State = value; }
        }

        public string zip
        {
            get { return _Zip; }
            set { _Zip = value; }
        }

        public string email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public int status
        {
            get { return _Status; }
            set { _Status = value; }
        }

    }
}
