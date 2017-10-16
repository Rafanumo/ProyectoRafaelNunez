using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BreweryApp
{
    public partial class DetalleCerveza : ContentPage
    {
        Beer Datos { get; set; }
        public DetalleCerveza(Beer cerveza)
        {
            IsBusy = false;
            Datos = cerveza;
            BindingContext = Datos;

            InitializeComponent();

            InitializeComponent();
        }
    }
}