using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GradGate
{
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();
        }

        internal void callpage(Uri uri)
        {
            webView.Source = uri;
        }


        void OnGoBackClicked(object sender, EventArgs args)
        {
            webView.GoBack();
        }

        void OnGoForwardClicked(object sender, EventArgs args)
        {
            webView.GoForward();
        }
    }
}
