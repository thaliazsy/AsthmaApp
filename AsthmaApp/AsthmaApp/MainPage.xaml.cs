using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AsthmaApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnButtonClicked(object sender, EventArgs args)
        {
            ImageButton sen = (ImageButton)sender;
            if (sen == sen.FindByName("btn_education"))
            {
                var page = new NavigationPage(new HealthEducation());
                Navigation.PushModalAsync(page);
            }
            else if (sen == sen.FindByName("btn_therapy"))
            {
                var page = new NavigationPage(new Rehabilitation());
                Navigation.PushModalAsync(page);
            }
            else if (sen == sen.FindByName("btn_decision"))
            {
                var page = new NavigationPage(new SharedDecisionMaking());
                Navigation.PushModalAsync(page);
            }
            else if (sen == sen.FindByName("btn_drug"))
            {
                var page = new NavigationPage(new Drug());
                Navigation.PushModalAsync(page);
            }
            else if (sen == sen.FindByName("btn_selfAsses"))
            {
                var page = new NavigationPage(new SelfAssesment());
                Navigation.PushModalAsync(page);
            }
            else if (sen == sen.FindByName("btn_qna"))
            {
                var page = new NavigationPage(new QuestionAnswer());
                Navigation.PushModalAsync(page);
            }
        }
    }
}