using App1_Cell.Modelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalheFuncionario : ContentPage
    {
        public DetalheFuncionario(Funcionario funcionario)
        {
            InitializeComponent();

            nomeFuncionario.Text = funcionario.Nome;
        }
    }
}