using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module2LabB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        DateTime today = DateTime.Today;
        DateTime birthday;

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            int year = Int32.Parse(Year.Text);
            int month = Int32.Parse(Month.Text);
            int day = Int32.Parse(Day.Text);
            birthday = new DateTime(year, month, day);

            //calculate age
            var age = today.Year - birthday.Year;
            var yearsToDrinking = 21 - age;

            if (age > 21)
            {
                todaysdatelabel.Text = "You can already drink!";
            } else if (age == 21)
            {
                todaysdatelabel.Text = "You can drink this year!";
            } else if (age < 21)
            {
                todaysdatelabel.Text = $"You can drink in {yearsToDrinking} years!";
            }

        }
    }
}
