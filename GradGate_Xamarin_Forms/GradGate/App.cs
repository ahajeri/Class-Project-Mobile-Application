using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GradGate
{
	public class App : Application
	{
        public static bool IsUserLoggedIn { get; set; }
        public static MobileServiceClient MobileService =
        new MobileServiceClient(
            "https://gradgate.azurewebsites.net");
        public App ()
		{
            // The root page of your application
              if (!IsUserLoggedIn)
              {
                  MainPage = new NavigationPage(new LoginPage());
              }
              else
                  MainPage = new NavigationPage(new LoginPage()); 

           // MainPage = new NavigationPage(new PickUpPage());



        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

