using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AsthmaApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Rehabilitation : ContentPage
    {
        public Rehabilitation()
        {
            InitializeComponent();
        }
        private void Home_Activated(object sender, EventArgs e)
        {
            foreach (Page page in Navigation.ModalStack)
            {
                Navigation.PopModalAsync();
            }

        }
    }
}