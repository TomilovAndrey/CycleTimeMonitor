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
//using Windows.Devices.Gpio;
//using System.Threading.Tasks;

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
          
        void SetNumOfSec(uint number)
        {
            number_of_sec = number;
        }
        void SetColorMode(char mode)
        {
            switch (mode)
            {
                case 'A':
                    Ellipse_1.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_2.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_3.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_4.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_5.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_6.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_7.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_8.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_9.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_10.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_11.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_12.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_13.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_14.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_15.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_16.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_17.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_18.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_19.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_20.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_21.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_22.Fill = new SolidColorBrush(Colors.Red);
                    Ellipse_23.Fill = new SolidColorBrush(Colors.Red);
                    Ellipse_24.Fill = new SolidColorBrush(Colors.Red);
                    Ellipse_25.Fill = new SolidColorBrush(Colors.Red);
                    Ellipse_26.Fill = new SolidColorBrush(Colors.Red);
                    break;
                case 'B':
                    Ellipse_1.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_2.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_3.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_4.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_5.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_6.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_7.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_8.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_9.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_10.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_11.Fill = new SolidColorBrush(Colors.Green);
                    Ellipse_12.Fill = new SolidColorBrush(Colors.Orange);
                    Ellipse_12.Stroke = new SolidColorBrush(Colors.DarkOrange);
                    Ellipse_13.Fill = new SolidColorBrush(Colors.Orange);
                    Ellipse_13.Stroke = new SolidColorBrush(Colors.DarkOrange);
                    Ellipse_14.Fill = new SolidColorBrush(Colors.Orange);
                    Ellipse_14.Stroke = new SolidColorBrush(Colors.DarkOrange);
                    Ellipse_15.Fill = new SolidColorBrush(Colors.Orange);
                    Ellipse_15.Stroke = new SolidColorBrush(Colors.DarkOrange);
                    Ellipse_16.Fill = new SolidColorBrush(Colors.Orange);
                    Ellipse_16.Stroke = new SolidColorBrush(Colors.DarkOrange);
                    Ellipse_17.Fill = new SolidColorBrush(Colors.Orange);
                    Ellipse_17.Stroke = new SolidColorBrush(Colors.DarkOrange);
                    Ellipse_18.Fill = new SolidColorBrush(Colors.Orange);
                    Ellipse_18.Stroke = new SolidColorBrush(Colors.DarkOrange);
                    Ellipse_19.Fill = new SolidColorBrush(Colors.Orange);
                    Ellipse_19.Stroke = new SolidColorBrush(Colors.DarkOrange);
                    Ellipse_20.Fill = new SolidColorBrush(Colors.Orange);
                    Ellipse_20.Stroke = new SolidColorBrush(Colors.DarkOrange);
                    Ellipse_21.Fill = new SolidColorBrush(Colors.Orange);
                    Ellipse_21.Stroke = new SolidColorBrush(Colors.DarkOrange);
                    Ellipse_22.Fill = new SolidColorBrush(Colors.Red);
                    Ellipse_23.Fill = new SolidColorBrush(Colors.Red);
                    Ellipse_24.Fill = new SolidColorBrush(Colors.Red);
                    Ellipse_25.Fill = new SolidColorBrush(Colors.Red);
                    Ellipse_26.Fill = new SolidColorBrush(Colors.Red);
                    break;
                case 'C':
                    break;
            }
        }
        void SetSec(int sec)
        {
            seconds = sec;
            textSec.Text = (System.String.Format("{0}", seconds));

            for (int i = 0; i < seconds; i++)
            {

            }        
        }

        public MainPage()
        {
            this.InitializeComponent();
            //SetColorMode('B');
            SetSec(13);
            //Task.Delay(-1).Wait(1000);                   
        }
    }
}
