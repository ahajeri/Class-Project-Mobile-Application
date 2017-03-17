using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GradGate
{
  
        public class Controller : ContentPage
        {
        public Controller()
        {
            Label Title = new Label()
            {
                Text = "Call-SMS-Email Sample",
                FontSize = 30,
                HorizontalOptions = LayoutOptions.Center
            };
            Entry MsgTo = new Entry()
            {
                Keyboard = Keyboard.Telephone,
                Placeholder = "Message To:"
            };
            Entry Message = new Entry()
            {
                Placeholder = "Enter Message"
            };
            Button SendSms = new Button()
            {
                Text = "Send"
            };

            Entry PhoneNumber = new Entry()
            {
                Keyboard = Keyboard.Telephone,
                Placeholder = "Enter phone number"
            };
            Button CallNo = new Button()
            {
                Text = "Call"
            };

            Entry EmailTo = new Entry()
            {
                Placeholder = "Eamil To:",
                Keyboard = Keyboard.Email
            };
            Entry EmailSubject = new Entry()
            {
                Placeholder = "Subject"
            };
            Entry EmailBody = new Entry()
            {
                Placeholder = "Message"
            };
            Button SendEmail = new Button()
            {
                Text = "Send email"
            };

            var stack = new StackLayout()
            {
                Spacing = 0,
                Children = { Title, MsgTo, Message, SendSms, PhoneNumber, CallNo,
                                                                 EmailTo, EmailSubject, EmailBody, SendEmail
                                                             }
            };
            Content = stack;

            //You have to add Nuget Packages on each platform
            SendSms.Clicked += (sender, e) =>
            {
                var SmsTask = MessagingPlugin.SmsMessenger;

                if (SmsTask.CanSendSms)
                    SmsTask.SendSms(MsgTo.Text, Message.Text);

            };

           // CallNo.Clicked += OnCallNo;
        }

        public void OnCallNUmber(string phone)
        {
            //Don't forgot to enable ID_CAP_PHONEDAILER on manifest file
            var PhoneCallTask = MessagingPlugin.PhoneDialer;

            if (PhoneCallTask.CanMakePhoneCall)
                PhoneCallTask.MakePhoneCall(phone);

        }

        public void OnEmailClicked(String emailId, String sub, String mailbody)
        {
            var EmailTask = MessagingPlugin.EmailMessenger;
            if (EmailTask.CanSendEmail)
                EmailTask.SendEmail(emailId, sub, mailbody);
        }
    }
}
