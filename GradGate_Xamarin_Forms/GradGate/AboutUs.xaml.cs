using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GradGate
{
    public partial class AboutUs : ContentPage
    {
        Controller ct = new Controller();
        public AboutUs()
        {
            InitializeComponent();
            phonephoto.Source = ImageSource.FromResource("GradGate.Images.phone.png");
            emailphoto.Source = ImageSource.FromResource("GradGate.Images.mail.png");
            ButtonImage.Source = ImageSource.FromResource("GradGate.Images.facebook.png");
            ButtonImage1.Source = ImageSource.FromResource("GradGate.Images.instagram.png");
            ButtonImage2.Source = ImageSource.FromResource("GradGate.Images.link.png");

            var tapGestureRecognizerButton = new TapGestureRecognizer();
            var tapGestureRecognizerButton1 = new TapGestureRecognizer();

            var tapGestureRecognizerimage = new TapGestureRecognizer();
            var tapGestureRecognizerimage1 = new TapGestureRecognizer();
            var tapGestureRecognizerimage2 = new TapGestureRecognizer();

            var tapGestureRecognizerlb = new TapGestureRecognizer();
            var tapGestureRecognizerlb1 = new TapGestureRecognizer();
            var tapGestureRecognizerlb2 = new TapGestureRecognizer();


            tapGestureRecognizerButton.Tapped += (s, e) =>
            {
                ct.OnCallNUmber(phoneU.Text);
            };
            phoneU.GestureRecognizers.Add(tapGestureRecognizerButton);


            tapGestureRecognizerButton1.Tapped += (s, e) =>
            {
                String EmailTo = mailU.Text;
                String EmailSubject = "Contact Us - GradGate";
                String EmailBody = "";

                ct.OnEmailClicked(EmailTo, EmailSubject, EmailBody);
            };
            mailU.GestureRecognizers.Add(tapGestureRecognizerButton1);

            WebViewPage wv = new WebViewPage();

            tapGestureRecognizerimage.Tapped += async (s, e) =>
            {
                Uri websource = new Uri("https://www.facebook.com/SantaClaraUniversity/");
                wv.callpage(websource);
                await Navigation.PushAsync(wv);
            };
            ButtonImage.GestureRecognizers.Add(tapGestureRecognizerimage);


            tapGestureRecognizerimage1.Tapped += async (s, e) =>
            {
                Uri websource = new Uri("https://www.instagram.com/santaclarauniversity/?hl=en");
                wv.callpage(websource);
                await Navigation.PushAsync(wv);
            };
            ButtonImage1.GestureRecognizers.Add(tapGestureRecognizerimage1);

            tapGestureRecognizerimage2.Tapped += async (s, e) =>
            {
                Uri websource = new Uri("http://www.linkedin.com/groups/144518/profile");
                wv.callpage(websource);
                await Navigation.PushAsync(wv);

            };
            ButtonImage2.GestureRecognizers.Add(tapGestureRecognizerimage2);

            tapGestureRecognizerlb.Tapped += async (s, e) =>
            {
                Uri websource = new Uri("https://www.linkedin.com/in/akshatahajeri");
                wv.callpage(websource);
                await Navigation.PushAsync(wv);

            };
            mem1Label.GestureRecognizers.Add(tapGestureRecognizerlb);


            tapGestureRecognizerlb1.Tapped += async (s, e) =>
            {
                Uri websource = new Uri("https://www.linkedin.com/in/akshatahajeri");
                wv.callpage(websource);
                await Navigation.PushAsync(wv);

            };
            mem3Label.GestureRecognizers.Add(tapGestureRecognizerlb1);

            tapGestureRecognizerlb2.Tapped += async (s, e) =>
            {
                Uri websource = new Uri("https://www.linkedin.com/in/balaji-sai-a4a08298?authType=NAME_SEARCH&authToken=AVgx&locale=en_US&trk=tyah&trkInfo=clickedVertical%3Amynetwork%2CclickedEntityId%3A346544986%2CauthType%3ANAME_SEARCH%2Cidx%3A1-1-1%2CtarId%3A1480983084649%2Ctas%3Abalaji%20sai");
                wv.callpage(websource);
                await Navigation.PushAsync(wv);

            };
            mem2Label.GestureRecognizers.Add(tapGestureRecognizerlb2);
        }


           
    }
}
