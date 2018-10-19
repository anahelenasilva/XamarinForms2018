using App2_ListaEstados.Modelo;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_ListaEstados
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CidadesPage : ContentPage
    {
        private List<Cidade> cidades { get; set; }
        public CidadesPage(Estado estado)
        {
            InitializeComponent();
            cidades = Servico.Servico.GetCidades(estado.id).OrderBy(o => o.nome).ToList();

            lvCidades.ItemsSource = cidades;
        }

        private void txtCidade_TextChanged(object sender, TextChangedEventArgs args)
        {
            if (!string.IsNullOrEmpty(args.NewTextValue))
            {
                lvCidades.ItemsSource = cidades.Where(w => w.nome.Contains(args.NewTextValue)).ToList();
            }
        }

        //private void lvCidades_ItemSelected(object sender, SelectedItemChangedEventArgs args)
        //{

        //}
    }
}