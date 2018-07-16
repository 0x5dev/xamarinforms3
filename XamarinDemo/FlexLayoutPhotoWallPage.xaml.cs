using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinDemo
{
    public partial class FlexLayoutPhotoWallPage : ContentPage
    {
        public FlexLayoutPhotoWallPage()
        {
            InitializeComponent();

            LoadImages();
        }


        private void LoadImages()
        {
            for (int i = 0; i < 100; i++)
            {

                Image image = new Image
                {
                    Source = ImageSource.FromFile("nick.png"),
                    HeightRequest = 100,
                    WidthRequest = 100,
                };

                flexLayout.Children.Add(image);
            }
        }
    }
}