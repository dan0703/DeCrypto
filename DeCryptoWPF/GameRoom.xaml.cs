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
using System.Windows.Shapes;

namespace DeCryptoWPF
{
    /// <summary>
    /// Lógica de interacción para GameRoom.xaml
    /// </summary>
    public partial class GameRoom : Window
    {
        public GameRoom()
        {
            InitializeComponent();
        }

        private void Button_GameRoom_TeamRead_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_GameRoom_TeamBlue_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_GameRoom_StartGame_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_GameRoom_SendCode_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_GameRoom_Chat_Click(object sender, RoutedEventArgs e)
        {
            if (Expander_GameRoom_Chat.IsExpanded) {
                Expander_GameRoom_Chat.IsExpanded = false;
            }
            else
            {
                Expander_GameRoom_Chat.IsExpanded = true;
            }
        }

        
    }
}
