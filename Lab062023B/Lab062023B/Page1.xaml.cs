using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab062023B
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnGetPeople_Clicked(object sender, EventArgs e)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { Name = "Hugo",LastName= "Torrico" });
            people.Add(new Person { Name = "Paco", LastName = "Lopez" });
            people.Add(new Person { Name = "Luis", LastName = "Marquez" });
            people.Add(new Person { Name = "Miguel", LastName = "Palomino" });


            lvPeople.ItemsSource = people;
        }
    }
}