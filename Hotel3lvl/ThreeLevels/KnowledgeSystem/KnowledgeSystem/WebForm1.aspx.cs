using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using BO;
namespace KnowledgeSystem
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private string getAll()
        {
            var l = ContactBLL.GetAll();
            //Console.WriteLine(l);
            StringBuilder str = new StringBuilder("");
            Contact contact;
            for (int i = 0; i < l.Count; i++)
            {
                contact = l[i];
                Console.WriteLine(contact.address);
                str.Append("<li>");
                str.Append(contact.contactId.ToString() + ". ");
                str.Append(contact.ownerId + " " + contact.name + "   " + contact.address + "   " + contact.city +
                    "   " + contact.state + "   " + contact.zip + "   " + contact.email + "   " + contact.status);
                str.Append("</li>");
            }
            return str.ToString();
        }

        protected void findallContacts_Click(object sender, EventArgs e)
        {
            try
            {
                ltrContacts.Text = getAll();
                //refreshBoxes();
            }
            catch (Exception err)
            {
                lblErrorMessage.Text = "Error " + err.Message;
            }
        }

        private int maxID()
        {
            var l = ContactBLL.GetAll();
            int max = 0;
            for (int i = 0; i < l.Count; i++)
                if (l[i].contactId > max)
                    max = l[i].contactId;
            return max + 1;
        }

        protected void bt1_Click(object sender, EventArgs e)
        {
            try
            {
                Contact cl = new Contact();
                cl.contactId = maxID();
                cl.ownerId = tb1.Text;
                cl.name = tb2.Text;
                cl.address = tb3.Text;
                cl.city = tb4.Text;
                cl.state = tb5.Text;
                cl.zip = tb8.Text;
                cl.email = tb9.Text;
                cl.status = int.Parse(tb10.Text);
                var i = ContactBLL.Add(cl);
                ltrContacts.Text = getAll();
                refreshBoxes();
            }
            catch (Exception err)
            {
                lblErrorMessage0.Text = "Error " + err.Message;
            }
        }

        private void refreshBoxes()
        {
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            tb4.Text = "";
            tb5.Text = "";
            tb8.Text = "";
            tb9.Text = "";
            tb10.Text = "";
            tb11.Text = "";
            tb12.Text = "";
            lblErrorMessage.Text = "";
            lblErrorMessage1.Text = "";
            lblErrorMessage2.Text = "";
            lblErrorMessage0.Text = "";
        }

        protected void bt2_Click(object sender, EventArgs e)
        {
            try
            {
                Contact cl = new Contact();
                cl.contactId = int.Parse(tb13.Text);
                cl.ownerId = tb1.Text;
                cl.name = tb2.Text;
                cl.address = tb3.Text;
                cl.city = tb4.Text;
                cl.state = tb5.Text;
                cl.zip = tb8.Text;
                cl.email = tb9.Text;
                cl.status = int.Parse(tb10.Text);
                var i = ContactBLL.Update(cl);
                ltrContacts.Text = getAll();
                refreshBoxes();
            }
            catch (Exception err)
            {
                lblErrorMessage0.Text = "Error " + err.Message;
            }
        }

        protected void bt3_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tb11.Text);
                ContactBLL.Delete(id);
                ltrContacts.Text = getAll();
                refreshBoxes();
            }
            catch (Exception err)
            {
                lblErrorMessage1.Text = "Error " + err.Message;
            }
        }

        protected void bt4_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tb12.Text);
                var l = ContactBLL.GetById(id);
                StringBuilder str = new StringBuilder("");
                str.Append("<li>");
                // str.Append(l.id.ToString() + ". ");
                str.Append(l.ownerId + " " + l.name + "   " + l.address + "   " + l.city + "   " + l.state + "   " + 
                    l.zip + "   " + l.email + "   " + l.status);
                str.Append("</li>");
                ltrContacts0.Text = str.ToString();
                refreshBoxes();
            }
            catch (Exception err)
            {
                lblErrorMessage2.Text = "Error " + err.Message;
            }
        }
    }
}