using App2_ListaEstados.Modelo;

using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_ListaEstados
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EstadosPage : ContentPage
    {
        public EstadosPage()
        {
            InitializeComponent();

            lvEstados.ItemsSource = Servico.Servico.GetEstados().OrderBy(o => o.nome).ToList();
        }

        private void lvEstados_ItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var estado = (Estado)args.SelectedItem;
            Navigation.PushAsync(new CidadesPage(estado));
        }
    }
}