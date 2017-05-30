using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App3
{
    public partial class Detail : ContentPage
    {
        public Detail()
        {
            InitializeComponent();

            BackgroundColor =  Color.FromHex("73efed");

          
            StackLayout Layout = new StackLayout
            {
                Spacing = 30,
                Padding = 300,
                Children =
                {
                    new Button {Image ="Assets/Shop2.png",Text ="Mundo Pet",TextColor = Color.White, BackgroundColor = Color.FromHex("6adbd9") },
                    new Button {Image = "Assets/heart.png",Text = "Saúde",TextColor = Color.White, BackgroundColor = Color.FromHex("6adbd9"),  },
                    new Button {Image = "Assets/profile.png",Text = "Ajude",TextColor = Color.White,BackgroundColor = Color.FromHex("6adbd9") }

                }

            };

            this.Content = Layout;
        }
    }
}
