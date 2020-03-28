using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.IO;

namespace BloodAppand.viaw
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Data_project : ContentPage
    {
        public Data_project()
        {
            InitializeComponent();

            //var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Data Source=C:/Users/Admin/source/repos/Visual_Blood/PDatabase.db3;");
            //var db = new SQLiteConnection(dbPath);
            //var query = db "Select * form ";


            // var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db3");
            //var db = new SQLiteConnection(dbPath);
            //var query = db.Table<UserTable>().Where(u => u.Username.Equals(EnUsername.Text) && u.Password.Equals(EnPassword.Text)).FirstOrDefault();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Home());
        }
    }
}