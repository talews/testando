﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            
            this.Master = new Master();
            this.Detail = new NavigationPage(new Detail());
            NavigationPage.SetHasNavigationBar(this, false);

            

        }
    }
}
