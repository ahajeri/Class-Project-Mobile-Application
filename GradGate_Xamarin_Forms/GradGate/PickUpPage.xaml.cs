using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GradGate
{
    public partial class PickUpPage : ContentPage
    {
        public PickUpPage()
        {
            InitializeComponent();
        }

        private void OnSendRequest(object sender, EventArgs e)
        {

            String EmailTo = "ahajeri@scu.edu";
            String EmailSubject = "Pick Up Request From Grad Gate";
            String EmailBody = "From : " + "\n Name: " + name.Text + "\n Email: " + email.Text + "\n Phone Number: " + phone.Text + "\n Emergency Phone Number: " + emePhone.Text + "\n AirLines: " + airlines.Text + "\n Flight Number: " + flightnum.Text
                + "\n Departure Date: " + dDate.Date.Day + "/" + dDate.Date.Month + "/" + dDate.Date.Year
                + "\n Arriving Date: " + aDate.Date.Day + "/" + aDate.Date.Month + "/" + aDate.Date.Year;
            Controller ct = new Controller();
            ct.OnEmailClicked(EmailTo, EmailSubject, EmailBody);
        }
    }
}
