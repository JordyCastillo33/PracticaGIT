﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PracticaGIT
{
    /// <summary>
    /// Lógica de interacción para Blanco.xaml
    /// </summary>
    public partial class Blanco : Window
    {
        public Blanco()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
              MainWindow mainWindow = new MainWindow();
              mainWindow.Show();
          
        }
    }
}
