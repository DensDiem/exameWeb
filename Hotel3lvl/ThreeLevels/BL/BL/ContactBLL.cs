using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BO;
using DAL;
namespace BLL
{
    public static class ContactBLL
    {
        public static List<Contact> GetAll()
        {
            return (new ContactDAO()).GetAll();
        }
        public static Contact GetById(int iD)
        {
            return (new ContactDAO()).Get(iD);
        }
        public static int Delete(int iD)
        {
            return (new ContactDAO()).Delete(iD);
        }
        public static int Update(Contact client)
        {
            return (new ContactDAO()).Update(client);
        }
        public static int Add(Contact client)
        {
            return (new ContactDAO()).Add(client);
        }
    }
}
