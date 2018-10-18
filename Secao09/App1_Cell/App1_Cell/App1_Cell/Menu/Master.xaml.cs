using App1_Cell.Paginas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void GoToTextCellPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TextCellPage());
            IsPresented = false;
        }

        private void GoToImageCellPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ImageCellPage());
            IsPresented = false;
        }

        private void GoToEntryCellPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new EntryCellPage());
            IsPresented = false;
        }

        private void GoToSwitchCellPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new SwitchCellPage());
            IsPresented = false;
        }

        private void GoToViewCellPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ViewCellPage());
            IsPresented = false;
        }

        private void GoToListViewPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ListViewPage());
            IsPresented = false;
        }

        private void GoToListViewButtonPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ListViewButtonPage());
            IsPresented = false;
        }
    }
}