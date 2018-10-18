using App1_Cell.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageCellPage : ContentPage
    {
        public ImageCellPage()
        {
            InitializeComponent();

            var listaFuncionario = new List<Funcionario>
            {
                new Funcionario { Nome = "Ana", Cargo = "Dev", Foto = "perfil.png" },
                new Funcionario { Nome = "Rene", Cargo = "Dev", Foto = "perfil.png" },
                new Funcionario { Nome = "Ivan", Cargo = "Scrum Master", Foto = "perfil.png" },
                new Funcionario { Nome = "Andressa", Cargo = "Product Owner", Foto = "perfil.png" }
            };

            lvFuncionario.ItemsSource = listaFuncionario;
        }
    }
}