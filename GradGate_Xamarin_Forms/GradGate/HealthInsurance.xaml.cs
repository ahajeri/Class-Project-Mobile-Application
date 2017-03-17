using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GradGate
{
    public partial class HealthInsurance : ContentPage
    {
        private Uri websource;


        public HealthInsurance()
        {
            InitializeComponent();
            var tapGestureRecognizer = new TapGestureRecognizer();
            var tapGestureRecognizer1 = new TapGestureRecognizer();
            WebViewPage wv = new WebViewPage();

            tapGestureRecognizer.Tapped += async (s, e) =>
            {
                websource = new Uri(uriLabel.Text);
                wv.callpage(websource);
                await Navigation.PushAsync(wv);
            };
            uriLabel.GestureRecognizers.Add(tapGestureRecognizer);

            tapGestureRecognizer1.Tapped += async (s, e) =>
            {
                websource = new Uri(uriLabel1.Text);
                wv.callpage(websource);
                await Navigation.PushAsync(wv);
            };
            uriLabel1.GestureRecognizers.Add(tapGestureRecognizer1);
        }
    }
}
