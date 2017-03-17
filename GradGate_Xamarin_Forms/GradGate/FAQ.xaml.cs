using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GradGate
{
    public partial class FAQ : ContentPage
    {
        public FAQ()
        {
            InitializeComponent();
            ansLabel1.IsVisible = false;
            ansLabel2.IsVisible = false;
            ansLabel3.IsVisible = false;
            ansLabel4.IsVisible = false;
            ansLabel5.IsVisible = false;
            ansLabel6.IsVisible = false;
            ansLabel7.IsVisible = false;
            var tapGestureRecognizer = new TapGestureRecognizer();
            var tapGestureRecognizer1 = new TapGestureRecognizer();
            var tapGestureRecognizer2 = new TapGestureRecognizer();
            var tapGestureRecognizer3 = new TapGestureRecognizer();
            var tapGestureRecognizer4 = new TapGestureRecognizer();
            var tapGestureRecognizer5 = new TapGestureRecognizer();
            var tapGestureRecognizer6 = new TapGestureRecognizer();
            WebViewPage wv = new WebViewPage();
            int tapcount =1 ;
            int tapcount1 = 1;
            int tapcount2= 1;
            int tapcount3= 1;
            int tapcount4= 1;
            int tapcount5= 1;
            int tapcount6= 1;

            tapGestureRecognizer.Tapped += (s, e) =>
            {
                tapcount++;

                if (tapcount % 2 == 0)
                {
                    ansLabel1.IsVisible = true;
                    ansLabel1.Text = "Unlike some other places in the US where the temperature hits extremes, Santa Clara is comparatively pleasant. During Winters the temperature dips down but then you should be good with a Jacket or a overcoat. Nothing to worry about. During summers, it does not get too hot. It may get warm at times but never really gives the â€œtoo hotâ€ feeling. Overall, the weather at Santa Clara is good. Do not get too many warm clothing with you. Its not required!"
                    ;
                }
                else
                {
                    ansLabel1.IsVisible = false;
                }
            };
            listQLabel.GestureRecognizers.Add(tapGestureRecognizer);

            tapGestureRecognizer1.Tapped += (s, e) =>
            {
                tapcount1++;

                if (tapcount1 % 2 == 0)
                {
                    ansLabel2.IsVisible = true;
                    ansLabel2.Text = "Its preferable that you learn a little bit of cooking before you come here. As a student, its not financially feasible to eat out regularly. You would have to cook at home. So its better to be prepared."
                    ;
                }
                else
                {
                    ansLabel2.IsVisible = false;
                }

            };
            listQLabel1.GestureRecognizers.Add(tapGestureRecognizer1);


            tapGestureRecognizer2.Tapped += (s, e) =>
            {
                tapcount2++;

                if (tapcount2 % 2 == 0)
                {
                    ansLabel3.IsVisible = true;
                    ansLabel3.Text = " There are a lot of On Campus jobs at the University. You will have to apply through the Bronco Link and also drop in your resumes at different places. You may take a while in finding a job but eventually everyone gets it. Bon Appetit and Library are the two places that offer the maximum number of jobs.";
                }
                else
                {
                    ansLabel3.IsVisible = false;
                }
            };
            listQLabel2.GestureRecognizers.Add(tapGestureRecognizer2);

            tapGestureRecognizer3.Tapped += (s, e) =>
            {
                tapcount3++;

                if (tapcount3 % 2 == 0)
                {
                    ansLabel4.IsVisible = true;
                    ansLabel4.Text = " Its preferable that you learn a little bit of cooking before you come here. As a student, its not financially feasible to eat out regularly. You would have to cook at home. So its better to be prepared.?";
                }
                else
                {
                    ansLabel4.IsVisible = false;
                }
            };
            listQLabel3.GestureRecognizers.Add(tapGestureRecognizer3);

            tapGestureRecognizer4.Tapped += (s, e) =>
            {
                tapcount4++;

                if (tapcount4 % 2 == 0)
                {
                    ansLabel5.IsVisible = true;
                    ansLabel5.Text = "Yes you can! Students generally go to India during the Summer quarter as this is an optional quarter. Taking up courses in this quarter is optional. But keep in mind, before leaving for India, please visit the ISS as there could be some modifications required on your I-20 before leaving US. Whenever you are leaving the country as a student, please consult the ISS before doing so."
                ;
                }
                else
                {
                    ansLabel5.IsVisible = false;
                }
            };
            listQLabel4.GestureRecognizers.Add(tapGestureRecognizer4);

            tapGestureRecognizer5.Tapped += (s, e) =>
            {
                tapcount5++;

                if (tapcount5 % 2 == 0)
                {
                    ansLabel6.IsVisible = true;
                    ansLabel6.Text = "You must carry a pair of traditional attire with you. College organizes various Indian events and its always good to be dressed in traditional attire. Also, this area has a lot of Indian population and hence there are a lot of events going on. Traditional clothes will definitely come in Handy."
                ;
                }
                else
                {
                    ansLabel6.IsVisible = false;
                }
            };
            listQLabel5.GestureRecognizers.Add(tapGestureRecognizer5);


            tapGestureRecognizer6.Tapped += (s, e) =>
            {
                tapcount6++;

                if (tapcount6 % 2 == 0)
                {
                    ansLabel7.IsVisible = true;
                    ansLabel7.Text = "Please bring enough contact lenses with you. You can carry lenses to last you for 6-8 months. The solution and the container are available here but then lenses will work out expensive. More so, if you have Astigmatism, please make special astigmatism lenses from India itself. It would be very expensive here."
                ;
                }
                else
                {
                    ansLabel7.IsVisible = false;
                }
            };
            listQLabel6.GestureRecognizers.Add(tapGestureRecognizer6);
        }
    }
}
