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
    public partial class QuestionAnswer : ContentPage
    {
        public QuestionAnswer()
        {
            InitializeComponent();

        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            ImageButton sen = (ImageButton)sender;
            int index;
            int.TryParse(sen.CommandParameter.ToString(), out index);
            var page = new NavigationPage(new Answers(index));
            Navigation.PushModalAsync(page);
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