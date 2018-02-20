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
        uint number_of_sec;
        int seconds;
        bool start_flag = false;

        SolidColorBrush red = new SolidColorBrush(Colors.Red);

        void SetNumOfSec(uint number)
        {
            number_of_sec = number;
            SecProgress.Minimum = 0;
            SecProgress.Maximum = number_of_sec;
        }
        void SetSec(int sec)
        {
            seconds = sec;
            textSec.Text = (System.String.Format("{0}", seconds));
            SecProgress.Value = seconds;
        }
        async void StartCountCycle()
        {
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
        private void Start_Click(object sender, System.EventArgs e)
        {
            start_flag = true;
        }
        private void Stop_Click(object sender, System.EventArgs e)
        {
            start_flag = false;
        }

        public MainPage()
        {
            this.InitializeComponent();

            var gpio = GpioController.GetDefault();

            GpioPin pin_start = gpio.OpenPin(5);

            pin_start.SetDriveMode(GpioPinDriveMode.Input);

            SetNumOfSec(26);
            
            while(true)
            {
                while(start_flag == true)
                {
                    var start_flag = pin_start.Read();

                    if (start_flag == GpioPinValue.High)
                    {
                        StartCountCycle();
                    }
                }
            }
        }
    }
}
