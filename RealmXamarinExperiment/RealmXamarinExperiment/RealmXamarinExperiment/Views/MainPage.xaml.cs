using System.Diagnostics;
using System.Linq;
using Realms;
using RealmXamarinExperiment.Models;
using Xamarin.Forms;

namespace RealmXamarinExperiment.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AddNewRecord();
        }

        public void AddNewRecord()
        {
            var realm = Realm.GetInstance();
            var person = new Person {Name = "Deva", Age = 34};
            realm.Write(() =>
            {
                realm.Add(person);
            });

            var p = realm.All<Person>().First(d => d.Age == 34); 
            Debug.WriteLine($"Person name ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: {p.Name}");
        }
    }
}
