using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GradGate
{
    public partial class TemporaryHome : ContentPage
    {
        public TemporaryHome()
        {
            InitializeComponent();
        }

        private void OnSendRequest(object sender, EventArgs e)
        {

            String EmailTo = "ahajeri@scu.edu";
            String EmailSubject = "Temporary Stay Request From Grad Gate";
            String EmailBody = "From : " + "\n Name: " + name.Text + "\n Email: " + email.Text
                                 + "\n Arriving Date: " + date.Date.Day + "/" + date.Date.Month + "/" + date.Date.Year + "\n Length of stay: " + day.Text + "\n \n My Preferences: " + other.Text;
            Controller ct = new Controller();
            ct.OnEmailClicked(EmailTo, EmailSubject, EmailBody);
        }
    }
}
