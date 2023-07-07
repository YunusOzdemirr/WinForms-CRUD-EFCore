using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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

namespace Mobility.PrimeThreadWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ObservableCollection<int> Numbers1 = new ObservableCollection<int>();
        public static ObservableCollection<int> Numbers2 = new ObservableCollection<int>();

        public MainWindow()
        {
            InitializeComponent();
            Numbers1 = new ObservableCollection<int>();
            Numbers2 = new ObservableCollection<int>();
            Thread1List.ItemsSource = Numbers1;
            Thread2List.ItemsSource = Numbers2;
        }

        private async void Thread1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                for (int i = 0; i < 3600; i++)
                {
                    if (IsPrime(i))
                    {
                        Numbers1.Add(i);
                    }
                    await Task.Delay(250);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Thread2_Click(object sender, RoutedEventArgs e)
        {
            Thread newWindowThread = new Thread(new ThreadStart(PrimeCounter));
            newWindowThread.IsBackground = true;
            newWindowThread.Start();
        }

        public static void PrimeCounter()
        {
            for (int i = 0; i < 3600; i++)
            {
                if (IsPrime(i))
                    App.Current.Dispatcher.Invoke(new Action(async () =>
                    {
                        Numbers2.Add(i);
                    }));
                        Thread.Sleep(250);
            }
        }
      
        public static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
