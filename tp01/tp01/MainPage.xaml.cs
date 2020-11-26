﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace tp01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void okClick(object sender, EventArgs e)
        {
            string idValue = id.Text;
            string passValue = pass.Text;
            if(idValue == "admin" && passValue == "senha@admin")
            {
                await DisplayAlert("Login", "Usuario logado com sucesso!", "OK");
            }
            else
            {
                await DisplayAlert("Login","Usuario não autorizado","OK");
            }
        }

        private void limparClick(object sender, EventArgs e)
        {
            id.Text = "";
            pass.Text = "";

            id.Focus();
        }

        async void creditosClick(object sender, EventArgs args)
        {
            await DisplayAlert("Autores", "Sandyara Peres e Bruno Fernandes", "OK");
        }
    }
}
