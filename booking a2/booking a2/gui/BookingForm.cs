using booking_a2.dbAccess;
using booking_a2.objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace booking_a2.gui
{
    public partial class BookingForm : Form
    {

        private Database db;

        public BookingForm()
        {
            InitializeComponent();
            db = booking_a2.Menu.Db;
            fillComboBox();
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            bool valid = true;
            dbAccess.CustomerDBAccess cDBAccess = new dbAccess.CustomerDBAccess(db);
            dbAccess.BookingDBAccess bDBAccess = new dbAccess.BookingDBAccess(db);
            objects.Customer customer = new objects.Customer();
            objects.Booking booking = new objects.Booking();
            customer.Forename = txtbForename.Text;
            try
            {
                customer.Surname = txtbSurname.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                valid = false;
            }

            customer.TelNo = txtbTelNo.Text;
            try
            {
                booking.StartDate = calStart.SelectionStart;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                valid = false;
            }
            
            
            try
            {
                customer.Address = txtbAddress.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                valid = false;
            }


            try
            {
                booking.EndDate = calEnd.SelectionStart;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                valid = false;
            }


            try
            {
                booking.StartDate = calStart.SelectionStart;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                valid = false;
            }


            if (valid)
            {
                cDBAccess.UpdateCustomer(customer);
                MessageBox.Show("Project Updated.");


            }
        }

        
        private void fillComboBox()
        {
            List<Customer> customers = new List<Customer>();
            CustomerDBAccess cDBa = new CustomerDBAccess(db);
            customers = cDBa.getAllCustomers();
            foreach (Customer cust in customers)
            {
                cboxSelectCustomer.Items.Add(cust.CustomerID.ToString() + "-" + cust.Forename + cust.Surname);
            }
        }


    }
}
