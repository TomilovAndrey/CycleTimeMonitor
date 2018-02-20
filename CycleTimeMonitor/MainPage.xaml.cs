using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI;
using Windows.Devices.Gpio;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419
namespace CycleTimeMonitor
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        static int number_of_sec;
        int seconds;
        bool start_flag;

        SolidColorBrush red = new SolidColorBrush(Colors.Red);

        void SetSec(int sec)
        {
            seconds = sec;
            textSec.Text = (System.String.Format("{0}", seconds));
            SecProgress.Value = seconds;
        }
        static public void SetNumOfSec(int number)
        {
            number_of_sec = number;
        }
        async void StartCountCycle()
        {
            SecProgress.Minimum = 0;
            SecProgress.Maximum = number_of_sec;

            for (int i=0;i<number_of_sec;i++)
            {
                SetSec(i + 1);
                if (i + 1 > number_of_sec - 5)
                {
                    textSec.Foreground = red;
                    SecProgress.Foreground = red;
                }
                await Task.Delay(1000);
            }
        }
        void Start_Click(object sender, RoutedEventArgs e)
        {
            start_flag = true;
            StartCountCycle();
        }
        void Stop_Click(object sender, RoutedEventArgs e)
        {
            start_flag = false;
        }
        void Settings_Click(object sender, RoutedEventArgs e)
        {
            Settings settings_win = new CycleTimeMonitor.Settings();
            settings_win.ShowAsync();
        }

        public MainPage()
        {
            this.InitializeComponent();
        }
    }
}
