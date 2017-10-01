using System;
using System.Windows;
using MahApps.Metro.Controls;

namespace MahAppTabControlIssue
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        public MainWindow()
        {
            InitializeComponent();
            Add.Click += AddOnClick;
        }

        private void AddOnClick(object sender, RoutedEventArgs routedEventArgs)
        {
            var n = Test.Items.Count+1;
            Test.Items.Add(new MetroTabItem
            {
                Header = "ServiceRegistry"
            });
        }
    }
}
