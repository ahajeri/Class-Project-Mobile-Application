using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GradGate
{
    public partial class LoginPage : ContentPage
    {
        LoginManager manager;
        ObservableCollection<LoginData> list = new ObservableCollection<LoginData>();
        string email;
        public LoginPage()
        {
            InitializeComponent();
            manager = LoginManager.DefaultManager;
            ButtonImage1.Source = ImageSource.FromResource("GradGate.Images.gradfourm.png");
        }

        async Task AddItem(LoginData item)
        {
            await manager.SaveTaskAsync(item);
            //replyList.ItemsSource = await manager.GetReplyAsync(temp);
        }
        public async void OnComplete(object sender, EventArgs e)
        {
            email = emailU.Text;
            LoginData item = new LoginData
            {
                Email = emailU.Text,
                Password = passwordU.Text,
                College = "college",
                Name = "name",
                PhoneNumber = "photo",
                Program = "program",
                //Comment = "yes it is",
                Done = false

            };
            // await AddItem(item);
            await App.MobileService.GetTable<LoginData>().InsertAsync(item);
        }

        public async void OnSignIn(Object sender,EventArgs e)
        {


            email = emailU.Text;
            list = await manager.GetLoginDataAsync(email);
            var isValid = false;
            if (list.Count <= 0)
            {
                await DisplayAlert("Alert", "UserName doesnot exist", "OK");
                isValid = false;
            }
            else
            {
                isValid = AreCredentialsCorrect(list);
            }
             
            if (isValid)
            {
                App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new MainPage(), this);
                await Navigation.PopAsync();
            }
            else if(list.Count > 0)
            {
                await DisplayAlert("Alert", "UserName and Password Does not Match", "OK");
            }

        }

        private bool AreCredentialsCorrect(ObservableCollection<LoginData> list)
        {
            if (list[0].Password == passwordU.Text)
            {
                return true;
            }
            else
            {
                return false;  
            }
        }

        public async void OnCreate(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUp());
        }
    }
}
