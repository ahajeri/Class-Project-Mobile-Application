using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GradGate
{
    public partial class SignUp : ContentPage
    {
        LoginManager manager;
        ObservableCollection<LoginData> list = new ObservableCollection<LoginData>();
        string email;
        public SignUp()
        {
            InitializeComponent();
            manager = LoginManager.DefaultManager;

        }

        public async void OnSignup(object sender, EventArgs e)
        {

            email = emailU.Text;
            list = await manager.GetLoginDataAsync(email);

            LoginData item = new LoginData
            {
                Email = emailU.Text,
                Password = passwordU.Text,
                College = collegeU.Text,
                Name = nameU.Text,
                PhoneNumber = phoneNumberU.Text,
                Program = programU.Text,
                //Comment = "yes it is",
                Done = false

            };

            var signUpSucceeded = AreDetailsValid(item);
            if (signUpSucceeded > 1)
            {
                var rootPage = Navigation.NavigationStack.FirstOrDefault();
                if (rootPage != null)
                {
                    await App.MobileService.GetTable<LoginData>().InsertAsync(item);
                    App.IsUserLoggedIn = true;
                    Navigation.InsertPageBefore(new LoginPage(), Navigation.NavigationStack.First());
                    await Navigation.PopToRootAsync();
                }
            }
            else if(signUpSucceeded == -2)
            {
                await DisplayAlert("Alert", "UserName already exist", "OK");
            }
            else if(signUpSucceeded == -1)
            {
                await DisplayAlert("Alert", "Check all the required field and with no spaces and correct email Id", "OK");
            }
            else if (signUpSucceeded == -3)
            {
                await DisplayAlert("Alert", "Password Doest Not Match", "OK");
            }
        }

        private int AreDetailsValid(LoginData item)
        {
            if(!(!string.IsNullOrWhiteSpace(item.Name) && !string.IsNullOrWhiteSpace(item.Password) && (item.Password.Length > 5) &&!string.IsNullOrWhiteSpace(item.Email) && item.Email.Contains("@")))
            {
                return -1;
            }
            if(!(passwordU.Text == confirmp.Text))
            {
                return -3;
            }
            if (list.Count > 0)
            {
                return -2;
            }
            else
                return 3;
        }

        // await AddItem(item);
        async Task AddItem(LoginData item)
        {
            await manager.SaveTaskAsync(item);
            //replyList.ItemsSource = await manager.GetReplyAsync(temp);
        }

       /* public void OnPasswordComplete(object sender, EventArgs e)
        {
            string password;
            password = passwordU.Text;
            if(password.Length < 6)
            {

            }
        } */

    }   
 }
