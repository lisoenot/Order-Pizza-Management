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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Order_Pizza_Management.ViewModels;

namespace Order_Pizza_Management
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            OrderingGrid.Visibility = Visibility.Visible;
            NoNameGrid.Visibility = Visibility.Hidden;
        }

        private void ReportButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ContolButton_Click(object sender, RoutedEventArgs e)
        {
            NoNameGrid.Visibility = Visibility.Visible;
            OrderingGrid.Visibility = Visibility.Hidden;
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            MenuGrid.Visibility = Visibility.Visible;
            CustomGrid.Visibility = Visibility.Hidden;
        }

        private void CustomButton_Click(object sender, RoutedEventArgs e)
        {
            CustomGrid.Visibility = Visibility.Visible;
            MenuGrid.Visibility = Visibility.Hidden;
        }

    }
}