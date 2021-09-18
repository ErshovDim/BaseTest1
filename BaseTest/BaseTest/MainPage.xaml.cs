using System;
using Xamarin.Forms;

namespace BaseTest
{
   
    public partial class MainPage : ContentPage
    {
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            StadiumView.ItemsSource = await App.BaseStadium.GetStadiumsAsync();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(LocationEntry.Text) && !string.IsNullOrWhiteSpace(SizeEntry.Text) && !string.IsNullOrWhiteSpace(DescriptionEntry.Text) && !string.IsNullOrWhiteSpace(NameEntry.Text))
            {
                await App.BaseStadium.SaveStadiumAsync(new Stadium
                {
                    Name = NameEntry.Text,
                    Location = LocationEntry.Text,
                    Size = int.Parse(SizeEntry.Text),
                    Description = DescriptionEntry.Text
                });

                NameEntry.Text = SizeEntry.Text = LocationEntry.Text = DescriptionEntry.Text = string.Empty;
                StadiumView.ItemsSource = await App.BaseStadium.GetStadiumsAsync();
            }
        }
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
