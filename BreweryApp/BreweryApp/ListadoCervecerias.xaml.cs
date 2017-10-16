using BreweryApp.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace BreweryApp
{
    public partial class ListadoCervecerias : ContentPage
    {
        public IList<Datum> Datos { get; set; }
        public ICommand ComandoRefrescar { get; set; }

        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
        }

        public ListadoCervecerias()
        {
            IsBusy = false;

            Datos = new ObservableCollection<Datum> {
                new Datum { Name = "Cargando..." },
                new Datum { Name = "Espere" }
            };

            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            IsBusy = true;

            var servicio = new ServicioCerveceria();

            var resultado = await servicio.Obtener();

            var cervecerias = resultado.Data;

            Datos.Clear();

            foreach (var item in cervecerias)
            {
                Datos.Add(item);
            }

            IsBusy = false;
        }

        public void OnMore(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);

            //Navigation.PushModalAsync(new DetalleCerveceria(((Datum)mi.CommandParameter)));
            if(((Datum)mi.CommandParameter).Website != null)
            {
                DisplayAlert("Website", ((Datum)mi.CommandParameter).Website, "OK");
            }
            else
            {
                DisplayAlert("Website", "Sorry, this brewery did not register your website yet.", "OK");
            }
        }

        public void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }
            Navigation.PushModalAsync(new DetalleCerveceria(((Datum)e.SelectedItem)));
            //Navigation.PushModalAsync(new DetalleCerveza(((Beer)e.SelectedItem)));
        }

    }
}