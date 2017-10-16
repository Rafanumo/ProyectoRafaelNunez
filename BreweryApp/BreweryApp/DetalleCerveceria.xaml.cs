using System;

using Xamarin.Forms;

namespace BreweryApp
{
    public partial class DetalleCerveceria : ContentPage
    {
        Datum Datos { get; set; }
        public DetalleCerveceria(Datum datos)
        {
            IsBusy = false;
            Datos = datos;
            BindingContext = Datos;

            InitializeComponent();

            btnBeers.Clicked += btnBeers_Clicked;
        }

        private void btnBeers_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ListadoCervezas(Datos.Id));
        }
    }
}