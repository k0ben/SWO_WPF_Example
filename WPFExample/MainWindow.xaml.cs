﻿using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Utils;

namespace WPFExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Algorithm algorithm;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(tbNumber.Text, out int number))
            { return; }
            algorithm = new Algorithm(number);
            algorithm.CalculationFinished += Alg_Finished;
            Task.Run(algorithm.DoCalculation);
        }

        private void Alg_Finished()
        {
            Dispatcher.Invoke(UpdateUI);
        }

        private void UpdateUI()
        {
            tbResult.Text = algorithm.Result.ToString();
        }
    }
}