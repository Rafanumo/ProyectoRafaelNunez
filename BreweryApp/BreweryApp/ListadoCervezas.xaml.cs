using BreweryApp.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BreweryApp
{
    public partial class ListadoCervezas : ContentPage
    {
        public IList<Beer> Datos { get; set; }
        public ICommand ComandoRefrescar { get; set; }
        public string IdBrewery { get; set; }

        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
        }

        public ListadoCervezas(string id)
        {
            IsBusy = false;

            Datos = new ObservableCollection<Beer> {
                new Beer { name = "Cargando..." },
                new Beer { name = "Espere" }
            };

            IdBrewery = id;
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            IsBusy = true;

            var servicio = new ServicioCerveceria();

            var resultado = await servicio.ObtenerCervezas(IdBrewery);

            var beers = resultado.data;

            Datos.Clear();

            foreach (var item in beers)
            {
                Datos.Add(item);
            }

            IsBusy = false;
        }

        public void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }
            Navigation.PushModalAsync(new DetalleCerveza(((Beer)e.SelectedItem)));
        }
    }
}