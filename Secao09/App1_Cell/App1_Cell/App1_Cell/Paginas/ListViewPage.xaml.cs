using App1_Cell.Modelo;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            var listaFuncionario = new List<Funcionario>
            {
                new Funcionario { Nome = "Ana", Cargo = "Dev" },
                new Funcionario { Nome = "Rene", Cargo = "Dev" },
                new Funcionario { Nome = "Ivan", Cargo = "Scrum Master" },
                new Funcionario { Nome = "Andressa", Cargo = "Product Owner" }
            };

            lvFuncionario.ItemsSource = listaFuncionario;
        }

        private void lvFuncionario_ItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var funcionario = (Funcionario)args.SelectedItem;
            Navigation.PushAsync(new DetalheFuncionario(funcionario));
        }

        private void MenuItem_Ferias_Clicked(object sender, EventArgs e)
        {
            var funcionario = (Funcionario)((MenuItem)sender).CommandParameter;
            DisplayAlert("Info", $"Férias para o Funcionário: {funcionario.Nome} - {funcionario.Cargo}", "OK");
        }

        private void MenuItem_Abono_Clicked(object sender, EventArgs e)
        {
            var funcionario = (Funcionario)((MenuItem)sender).CommandParameter;
            DisplayAlert("Info", $"Abono do Funcionário: {funcionario.Nome} - {funcionario.Cargo}", "OK");
        }
    }
}