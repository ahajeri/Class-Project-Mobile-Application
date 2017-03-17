using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GradGate
{
    public partial class TestPage1 : ContentPage
    {
        public TestPage1()
        {
            InitializeComponent();
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += async (s, e) =>
            {
                await Navigation.PushAsync(new Comment());
            };
            tapReply.GestureRecognizers.Add(tapGestureRecognizer);
        }
    }
}
