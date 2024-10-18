using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Documents;

namespace Pampers10
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

      

        private void SetBlue_Click(object sender, RoutedEventArgs e)
        {
            Color.Background = new SolidColorBrush(Colors.Blue);
            StatusBarItem.Content = "Синий цвет установлен.";
        }

        private void SetGreen_Click(object sender, RoutedEventArgs e)
        {
            Color.Background = new SolidColorBrush(Colors.Green);
            StatusBarItem.Content = "Зеленый цвет установлен.";
        }

        private void SetRed_Click(object sender, RoutedEventArgs e)
        {
            Color.Background = new SolidColorBrush(Colors.Red);
            StatusBarItem.Content = "Красный цвет установлен.";
        }

   
        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            StatusBarItem.Content = "Готово";
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Здесь может быть информация.");
        }

        private void MenuItem_Click2(object sender, RoutedEventArgs e)
        {
            Close(); 
        }




    }




}
