using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App3
{
    public partial class Menu : ContentPage
    {
        protected async void OnClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new MainPage());
        }
        public Menu()
        {

            InitializeComponent();

            Button Login = new Button
            {
                Text = "Login",
                TextColor = Color.White,
                BackgroundColor = Color.FromHex("3bccc9"),

            };

            Label label2 = new Label()
            {
                Text = "Ainda não tem uma conta?"

            };
            Label label = new Label()
            {
                Text = "Criar nova Conta",
                TextColor = Color.FromHex("3bccc9"),

            };

            StackLayout layout = new StackLayout
            {
                Padding = 20,
                Spacing = 50,
                VerticalOptions = LayoutOptions.Center,
                Children =
            {
                new Entry {Placeholder = "E-mail ou Usúario"},
                new Entry {Placeholder = "Senha ",IsPassword = true },
               label,
               Login


                    }
            };
            this.Content = layout;
            BackgroundColor = Color.White;

            var TapGesture = new TapGestureRecognizer();
            TapGesture.Tapped += (s, e) =>            //Evento para Toque no Texto
            {
                label.Navigation.PushAsync(new Cadastro());
            };

            NavigationPage.SetHasNavigationBar(this, false);
            label.GestureRecognizers.Add(TapGesture);
            Login.Clicked += OnClicked;

        }
    }
}
