using System;
using Xamarin.Forms;

namespace BreweryApp
{
    public partial class MaestroDetalle
    {
        public MaestroDetalle()
        {
            InitializeComponent();
            Master = new ContentPage() { Title = "Master" };
            botonNavegar.Clicked += BotonNavegar_Clicked;
        }

        private void BotonNavegar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ListadoCervecerias());
        }
        //private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var item = e.SelectedItem as MaestroDetalleMenuItem;
        //    if (item == null)
        //        return;

        //    var page = (Page)Activator.CreateInstance(item.TargetType);
        //    page.Title = item.Title;

        //    Detail = new NavigationPage(page);
        //    IsPresented = false;

        //    MasterPage.ListView.SelectedItem = null;
        //}
    }
}