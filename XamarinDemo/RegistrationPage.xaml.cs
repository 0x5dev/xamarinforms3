using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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
            var isValid = !String.IsNullOrEmpty(e.NewTextValue) && e.NewTextValue.Length > 6 ? "Valid" : "Invalid";
            VisualStateManager.GoToState((VisualElement)sender, isValid);
            VisualStateManager.GoToState(passwordMsg, isValid);

            if (e.NewTextValue.Length > 10)
            {
                VisualStateManager.GoToState(strengthLabel, "Strong");
            }else if(e.NewTextValue.Length > 8){
                VisualStateManager.GoToState(strengthLabel, "Medium");
            }else if(e.NewTextValue.Length > 6){
                VisualStateManager.GoToState(strengthLabel, "Weak");
            }
        }

        public void PhoneNumberChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            var match = Regex.Match(e.NewTextValue, "[0-9][0-9][0-9]-[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]");
            var isValid =  match.Success ? "Valid" : "Invalid";
            VisualStateManager.GoToState((VisualElement)sender, isValid);
            VisualStateManager.GoToState(phoneNumberMsg, isValid);
        }

        public void FavoritePetChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            var isValid = !String.IsNullOrEmpty(e.NewTextValue) ? "Valid" : "Invalid";
            VisualStateManager.GoToState((VisualElement)sender, isValid);
            VisualStateManager.GoToState(favoritePetMsg, isValid);
        }


        void Handle_Clicked(object sender, System.EventArgs e)
        {

        }
    }
}
