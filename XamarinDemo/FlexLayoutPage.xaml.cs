using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinDemo
{
    public partial class FlexLayoutPage : ContentPage
    {
        public FlexLayoutPage()
        {
            InitializeComponent();
        }

        void CodingPageClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FlexLayoutCodingPage());
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FlexLayoutPhotoWallPage());
        }
    }
}
