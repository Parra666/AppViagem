using App1.Model;
using App1.View;
using Xamarin.Forms;

using System.Globalization;
using System.Threading;
using System.Collections.ObjectModel;

namespace App1
{
    public partial class App : Application
    {
        public static ObservableCollection<Pedagio> ListaPedagios = new ObservableCollection<Pedagio>();

        public App()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            MainPage = new NavigationPage(new DadosViagem());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
