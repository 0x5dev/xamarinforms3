using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinDemo
{
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        public void UsernameChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {

            var isValid = !String.IsNullOrEmpty(e.NewTextValue) ? "Valid" : "Invalid";
            VisualStateManager.GoToState((VisualElement)sender, isValid);
            VisualStateManager.GoToState(usernameMsg, isValid);
        }

        public void PasswordChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {

        }

        public void PhoneNumberChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {

        }

        public void FavoritePetChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {

        }


        void Handle_Clicked(object sender, System.EventArgs e)
        {

        }
    }
}
