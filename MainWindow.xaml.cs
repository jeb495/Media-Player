using Microsoft.Win32;
using System;
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

namespace MusicApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region METHOD DECLARATION & ARRAY DECLARATION
        
        MediaPlayer player = new MediaPlayer();

        
        OpenFileDialog fileDialog = new OpenFileDialog()
        {
            Multiselect = true,
            DefaultExt = ".mp3"

        };
        
        string[] musicQueue = new string[] { "", ""};
        
        
        #endregion

        #region BUTTONS
        private void Button_Click_Open(object sender, RoutedEventArgs e)
        {

            
            fileDialog.ShowDialog();

            
            musicQueue[0] = fileDialog.FileName;

            
            

            player.Open(new Uri(musicQueue[0]));

            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (musicQueue[0] != null)
            {
                player.Play();
                player.Volume = 500;
                
            }
        }
       
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            player.Pause();
        }
        
        #endregion

        #region SLIDERS
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            player.Volume = volumeSlider.Value - 0.5;
        }

        #endregion
        
        
    }
}
