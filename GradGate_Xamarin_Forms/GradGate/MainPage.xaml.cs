using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GradGate
{
    public partial class MainPage : ContentPage
    {
        ToolbarItem toolbarItem;
        Image imageview;
        String resourceIDimage1;
        int counter = 1;


        public MainPage()
        {
            InitializeComponent();

            var tapGestureRecognizerButton = new TapGestureRecognizer();
            var tapGestureRecognizerButton1 = new TapGestureRecognizer();
            var tapGestureRecognizerButton2 = new TapGestureRecognizer();
            var tapGestureRecognizerButton3 = new TapGestureRecognizer();
            var tapGestureRecognizerButton4 = new TapGestureRecognizer();

            var grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(80) }); //row-0
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(50) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(80) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(80) });//row-1
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(80) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(70) });//row-2
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(80) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(100) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(200) });



            TimeSpan timeStamp = TimeSpan.FromSeconds(2);
            Device.StartTimer(timeStamp, OnTimerTick);

            Image button = new Image
            {
                Source = ImageSource.FromResource("GradGate.Images.gradicon.png"),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };


            Label butLabel = new Label
            {
                Text = "Student Form",
                TextColor = Color.FromHex("6495ED"),
                FontAttributes = FontAttributes.Bold,
                FontSize = 16,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            Image button1 = new Image
            {
                Source = ImageSource.FromResource("GradGate.Images.gradHome.png"),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };


            Label but1Label = new Label
            {
                Text = "Temporary Home",
                TextColor = Color.FromHex("6495ED"),
                FontAttributes = FontAttributes.Bold,
                FontSize = 16,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };


            Image button2 = new Image
            {
                Source = ImageSource.FromResource("GradGate.Images.gradcar.png"),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };

            Label but2Label = new Label
            {
                Text = " Airport Pick Up",
                TextColor = Color.FromHex("6495ED"),
                FontAttributes = FontAttributes.Bold,
                FontSize = 16,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            Image button3 = new Image
            {
                Source = ImageSource.FromResource("GradGate.Images.gradaboutus.png"),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };

            Label but3Label = new Label
            {
                Text = "About Us",
                FontSize = 16,
                TextColor = Color.FromHex("6495ED"),
                FontAttributes = FontAttributes.Bold,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            Image button4 = new Image
            {
                Source = ImageSource.FromResource("GradGate.Images.GradFaq.png"),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };

            Label but4Label = new Label
            {
                Text = "FAQ's",
                FontSize = 16,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.FromHex("6495ED"),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            imageview = new Image
            {
                Source = ImageSource.FromResource("GradGate.Images.SCUMisson.png"),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };

            this.Content = new StackLayout
            {
                Padding = new Thickness(15),

                Children =
                {
                   new ScrollView
                    {
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        Content = grid
                    }

        }
            };


            grid.Children.Add(button, 0, 0);
            Grid.SetColumnSpan(button, 2);
            grid.Children.Add(butLabel, 0, 1);
            Grid.SetColumnSpan(butLabel, 2);
            grid.Children.Add(button1, 0, 2);
            grid.Children.Add(button2, 1, 2);
            grid.Children.Add(but1Label, 0, 3);
            grid.Children.Add(but2Label, 1, 3);
            grid.Children.Add(button3, 0, 4);
            grid.Children.Add(button4, 1, 4);
            grid.Children.Add(but3Label, 0, 5);
            grid.Children.Add(but4Label, 1, 5);
            grid.Children.Add(imageview, 0, 6);
            Grid.SetColumnSpan(imageview, 2);




            tapGestureRecognizerButton.Tapped += async (s, e) =>
            {
                await Navigation.PushAsync(new TodoList()); // for test page
            };
            button.GestureRecognizers.Add(tapGestureRecognizerButton);
            butLabel.GestureRecognizers.Add(tapGestureRecognizerButton);


            tapGestureRecognizerButton1.Tapped += async (s, e) =>
            {
                await Navigation.PushAsync(new TemporaryHome());
            };
            button1.GestureRecognizers.Add(tapGestureRecognizerButton1);
            but1Label.GestureRecognizers.Add(tapGestureRecognizerButton1);



            tapGestureRecognizerButton2.Tapped += async (s, e) =>
            {
                await Navigation.PushAsync(new PickUpPage());
            };
            button2.GestureRecognizers.Add(tapGestureRecognizerButton2);
            but2Label.GestureRecognizers.Add(tapGestureRecognizerButton2);

            tapGestureRecognizerButton3.Tapped += async (s, e) =>
            {
                await Navigation.PushAsync(new AboutUs());
            };
            button3.GestureRecognizers.Add(tapGestureRecognizerButton3);
            but3Label.GestureRecognizers.Add(tapGestureRecognizerButton3);


            tapGestureRecognizerButton4.Tapped += async (s, e) =>
            {
                await Navigation.PushAsync(new FAQ());
            };
            button4.GestureRecognizers.Add(tapGestureRecognizerButton4);
            but4Label.GestureRecognizers.Add(tapGestureRecognizerButton4);


        }

        async void OnLogout(object sender,EventArgs args)
        {
            App.IsUserLoggedIn = false;
            Navigation.InsertPageBefore(new LoginPage(), this);
            await Navigation.PopAsync();
        }

        async void OnToolbarItemClicked(object sender, EventArgs args)
        {
            toolbarItem = (ToolbarItem)sender;
            if (toolbarItem.Text == "Apartment Near You")
            {
                await Navigation.PushAsync(new ApartmentNearYou());
            }
            if (toolbarItem.Text == "Pack Your Bags")
            {
                await Navigation.PushAsync(new PackYourBags());
            }
            if (toolbarItem.Text == "Health Insurance")
            {
                await Navigation.PushAsync(new HealthInsurance());
            }

        }


        bool OnTimerTick()
        {
            switch (counter)
            {
                case 1:
                    resourceIDimage1 = "Images/para1.jpe";
                    imageview.Source = resourceIDimage1;
                    break;

                case 2:
                    resourceIDimage1 = "Images/para6.jpg";
                    imageview.Source = resourceIDimage1;
                    break;

                case 3:
                    // Load web bitmap.         
                    resourceIDimage1 = "Images/para3.jpg";
                    imageview.Source = resourceIDimage1;
                    break;

                case 4:
                    // Load web bitmap.         
                    resourceIDimage1 = "Images/para4.jpg";
                    imageview.Source = resourceIDimage1;
                    break;

                case 5:
                    // Load web bitmap.         
                    resourceIDimage1 = "Images/para5.jpg";
                    imageview.Source = resourceIDimage1;
                    break;

                case 6:
                    // Load web bitmap.         
                    resourceIDimage1 = "Images/para8.jpg";
                    imageview.Source = resourceIDimage1;

                    break;

                default:
                    counter = 0;
                    break;
            }

            counter++;
            return true;

        }
    }
}
