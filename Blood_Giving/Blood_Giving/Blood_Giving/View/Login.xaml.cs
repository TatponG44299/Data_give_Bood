using Blood_Giving;
using Blood_Giving.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BloodAppand.viaw
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyDatabase.db");
            var db = new SQLiteConnection(dbPath);
            var query = db.Table<User_TB>().Where(u => u.Username.Equals(EntryUsername.Text) && u.Password.Equals(EntryPassword.Text)).FirstOrDefault();

            if (query != null)
            {
                App.Current.MainPage = new NavigationPage(new Home());
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Error", "Invalid Username or Password", "Cancel", "Yes");
                    if (result)
                    {
                        await Navigation.PushAsync(new Login());
                    }
                    else
                    {
                        await Navigation.PushAsync(new Login());
                    }
                });
            }

        }
        private void Regis_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Register());
        }
    }
}