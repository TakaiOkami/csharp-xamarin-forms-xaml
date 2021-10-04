using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAMLInXamarinForms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrivacyModal : ContentPage
    {
        public PrivacyModal()
        {
            InitializeComponent();

            PopModal();
        }

        private async void AcceptButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync(true);
        }

        private async void PopModal()
        {
            await this.Navigation.PushAsync(new PrivacyModal(), true);
        }
    }
}