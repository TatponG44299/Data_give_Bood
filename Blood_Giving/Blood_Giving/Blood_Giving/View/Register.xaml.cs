using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.IO;
using Blood_Giving.Tables;
using Blood_Giving;

namespace BloodAppand.viaw
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Enter_Clicked(object sender, EventArgs e)
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyDatabase.db");
            var db = new SQLiteConnection(dbPath);
            db.CreateTable<User_TB>();

            var item = new User_TB()
            {
                Username = EntryUsername.Text,
                Password = EntryPassword.Text,
                Name = EntryName.Text,
                Type_Blood = EntryType_Blood.Text
            };

            db.Insert(item);

            if ((string.IsNullOrWhiteSpace(EntryUsername.Text)) || (string.IsNullOrEmpty(EntryUsername.Text)) ||
            (string.IsNullOrWhiteSpace(EntryPassword.Text)) || (string.IsNullOrEmpty(EntryPassword.Text)) ||
            (string.IsNullOrWhiteSpace(EntryName.Text)) || (string.IsNullOrEmpty(EntryName.Text)) ||
            (string.IsNullOrWhiteSpace(EntryType_Blood.Text)) || (string.IsNullOrEmpty(EntryType_Blood.Text)))
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Error", "Please Enter Data", "Cancel", "Yes");
                    if (result)
                    {
                        await Navigation.PushAsync(new Register());
                    }
                    else
                    {
                        await Navigation.PushAsync(new Register());
                    }
                });
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Successfull", "Registeration Successful", "Cancel", "Yes");
                    if (result)
                    {
                        App.Current.MainPage = new Login();
                    }
                });

                Navigation.PushAsync(new Login());
            }
        }
    }
}