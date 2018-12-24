using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ContactDAO : BaseDAO
    {
        public Contact Get(int id)
        {
            Contact contact = null;
            command.CommandText = "findContact";
            SqlParameter objParam = command.Parameters.Add("@param1", SqlDbType.Int);
            objParam.Value = id;
            SqlDataReader objReader = command.ExecuteReader();
            if (objReader.Read())
            {
                contact = getItem(objReader);
            }
            conn.Close();
            return contact;
        }
        public List<Contact> GetAll()
        {
            command.CommandText = "findAllContacts";
            return getItems();
        }
        public int Add(Contact ob)
        {
            command.CommandText = "addContact";
            setParameters(ob);
            var insertedRows = command.ExecuteNonQuery();
            var o = command.Parameters["RETURN VALUE"].Value;
            if (o != null)
                insertedRows = Convert.ToInt32(o);
            conn.Close();
            return insertedRows;
        }
        public int Update(Contact ob)
        {
            command.CommandText = "updateContact";
            //setParameters(ob);
            SqlParameter objParam1 = command.Parameters.Add("@ContactId", SqlDbType.Int);
            objParam1.Value = ob.contactId;
            SqlParameter objParam2 = command.Parameters.Add("@OwnerId", SqlDbType.NVarChar);
            objParam2.Value = ob.ownerId;
            SqlParameter objParam3 = command.Parameters.Add("@Name", SqlDbType.NVarChar);
            objParam3.Value = ob.name;
            SqlParameter objParam4 = command.Parameters.Add("@Address", SqlDbType.NVarChar);
            objParam4.Value = ob.address;
            SqlParameter objParam5 = command.Parameters.Add("@City", SqlDbType.NVarChar);
            objParam5.Value = ob.city;
            SqlParameter objParam6 = command.Parameters.Add("@State", SqlDbType.NVarChar);
            objParam6.Value = ob.state;
            SqlParameter objParam7 = command.Parameters.Add("@Zip", SqlDbType.NVarChar);
            objParam7.Value = ob.zip;
            SqlParameter objParam8 = command.Parameters.Add("@Email", SqlDbType.NVarChar);
            objParam8.Value = ob.email;
            SqlParameter objParam9 = command.Parameters.Add("@Status", SqlDbType.Int);
            objParam9.Value = ob.status;
            var insertedRows = command.ExecuteNonQuery();
            conn.Close();
            return insertedRows;
        }
        public int Delete(int id)
        {
            command.CommandText = "deleteContact";
            SqlParameter objParam = command.Parameters.Add("@ContactId", SqlDbType.Int);
            objParam.Value = id;
            int result = command.ExecuteNonQuery();
            conn.Close();
            return result;
        }
        private List<Contact> getItems()
        {
            var objReader = command.ExecuteReader();
            var list = new List<Contact>();
            while (objReader.Read())
            {
                list.Add(getItem(objReader));
            }
            conn.Close();
            return list;
        }

        private Contact getItem(SqlDataReader objReader)
        {
            var contact = new Contact();
            object ob = null;
            contact.contactId = int.Parse(objReader.GetValue(0).ToString());
            if ((ob = objReader.GetValue(1)) != DBNull.Value)
                contact.ownerId = Convert.ToString(ob);
            if ((ob = objReader.GetValue(2)) != DBNull.Value)
                contact.name = Convert.ToString(ob);
            if ((ob = objReader.GetValue(3)) != DBNull.Value)
                contact.address = Convert.ToString(ob);
            if ((ob = objReader.GetValue(4)) != DBNull.Value)
                contact.city = Convert.ToString(ob);
            if ((ob = objReader.GetValue(5)) != DBNull.Value)
                contact.state = Convert.ToString(ob);
            if ((ob = objReader.GetValue(6)) != DBNull.Value)
                contact.zip = Convert.ToString(ob);
            if ((ob = objReader.GetValue(7)) != DBNull.Value)
                contact.email = Convert.ToString(ob);
            if ((ob = objReader.GetValue(8)) != DBNull.Value)
                contact.status = int.Parse(Convert.ToString(ob));
            return contact;
        }
        private void setParameters(Contact ob)
        {
            SqlParameter objParam1 = command.Parameters.Add("@ContactId", SqlDbType.Int);
            objParam1.Value = ob.contactId;
            SqlParameter objParam2 = command.Parameters.Add("@OwnerId", SqlDbType.NVarChar);
            objParam2.Value = ob.ownerId;
            SqlParameter objParam3 = command.Parameters.Add("@Name", SqlDbType.NVarChar);
            objParam3.Value = ob.name;
            SqlParameter objParam4 = command.Parameters.Add("@Address", SqlDbType.NVarChar);
            objParam4.Value = ob.address;
            SqlParameter objParam5 = command.Parameters.Add("@City", SqlDbType.NVarChar);
            objParam5.Value = ob.city;
            SqlParameter objParam6 = command.Parameters.Add("@State", SqlDbType.NVarChar);
            objParam6.Value = ob.state;
            SqlParameter objParam7 = command.Parameters.Add("@Zip", SqlDbType.NVarChar);
            objParam7.Value = ob.zip;
            SqlParameter objParam8 = command.Parameters.Add("@Email", SqlDbType.NVarChar);
            objParam8.Value = ob.email;
            SqlParameter objParam9 = command.Parameters.Add("@Status", SqlDbType.Int);
            objParam9.Value = ob.status;
            SqlParameter objParam13 = command.Parameters.Add("RETURN VALUE", SqlDbType.Int);
            objParam13.Direction = ParameterDirection.ReturnValue;
        }
    }
}