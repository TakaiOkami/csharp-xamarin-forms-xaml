﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XAMLInXamarinForms.ViewModels;
using XAMLInXamarinForms.Views.Fitness;
using XAMLInXamarinForms.Views.Nutrition;

namespace XAMLInXamarinForms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPageView : ContentPage
    {
        public PlannerViewModel model = new PlannerViewModel();

        public NavigationPageView()
        {
            InitializeComponent();

            PrivacyModal stuff = new PrivacyModal();
        }

        private async void FitnessButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FitnessView());
        }

        private async void NutritionButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NutritionView());
        }
    }
}