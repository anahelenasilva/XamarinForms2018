﻿using App1_Cell.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextCellPage : ContentPage
    {
        public TextCellPage()
        {
            InitializeComponent();

            var listaFuncionario = new List<Funcionario>
            {
                new Funcionario { Nome = "Ana", Cargo = "Dev" },
                new Funcionario { Nome = "Rene", Cargo = "Dev" },
                new Funcionario { Nome = "Ivan", Cargo = "Scrum Master" },
                new Funcionario { Nome = "Andressa", Cargo = "Product Owner" }
            };

            lvFuncionario.ItemsSource = listaFuncionario;
        }
    }
}