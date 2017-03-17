using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GradGate
{
    public partial class ApartmentNearYou : ContentPage
    {
       
        Uri websource;
        public ApartmentNearYou()
        {
            InitializeComponent();
            var tapGestureRecognizer = new TapGestureRecognizer();
            var tapGestureRecognizer1 = new TapGestureRecognizer();
            var tapGestureRecognizer2 = new TapGestureRecognizer();
            var tapGestureRecognizer3 = new TapGestureRecognizer();
            WebViewPage wv = new WebViewPage();

            tapGestureRecognizer.Tapped += async (s, e) =>
            {
                websource = new Uri(uriAprt.Text);
                wv.callpage(websource);
                await Navigation.PushAsync(wv);
            };
            uriAprt.GestureRecognizers.Add(tapGestureRecognizer);

            tapGestureRecognizer1.Tapped += async (s, e) =>
            {
                websource = new Uri(uriAprt1.Text);
                wv.callpage(websource);
                await Navigation.PushAsync(wv);
            };
            uriAprt1.GestureRecognizers.Add(tapGestureRecognizer1);

            tapGestureRecognizer2.Tapped += async (s, e) =>
            {
                websource = new Uri(uriAprt2.Text);
                wv.callpage(websource);
                await Navigation.PushAsync(wv);
            };
            uriAprt2.GestureRecognizers.Add(tapGestureRecognizer2);

            tapGestureRecognizer3.Tapped += async (s, e) =>
            {
                websource = new Uri(uriAprt3.Text);
                wv.callpage(websource);
                await Navigation.PushAsync(wv);
            };
            uriAprt3.GestureRecognizers.Add(tapGestureRecognizer3);
        }

    }
}

