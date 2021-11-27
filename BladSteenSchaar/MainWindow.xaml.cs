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

namespace BladSteenSchaar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Random random = new Random();
        private string keuze;
        private string keuzePC;
        private int scoreSpeler = 0;
        private int scoreComputer = 0;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBlad_Click(object sender, RoutedEventArgs e)
        {
            txtOutputSpeler.Text = "Blad";
            keuze = txtOutputSpeler.Text.ToLower();
            txtOutputComputer.Text = RandomKeuze();
            WieWint();

        }

        private void btnSteen_Click(object sender, RoutedEventArgs e)
        {
            txtOutputSpeler.Text = "Steen";
            keuze = txtOutputSpeler.Text.ToLower();
            txtOutputComputer.Text = RandomKeuze();
            WieWint();

        }

        private void btnSchaar_Click(object sender, RoutedEventArgs e)
        {
            txtOutputSpeler.Text = "Schaar";
            keuze = txtOutputSpeler.Text.ToLower();
            txtOutputComputer.Text = RandomKeuze();
            WieWint();

        }

        private string RandomKeuze() 
        {
            
            random = new Random(); 
            string[] keuzeLijst = { "Blad", "Steen", "Schaar" };
            int index = random.Next(keuzeLijst.Length);
            if (index == 0)
            {
                txtOutputComputer.Text = "Blad";
                keuzePC = txtOutputComputer.Text.ToLower();
            }
            else if (index == 1)
            {
                txtOutputComputer.Text = "Steen";
                keuzePC = txtOutputComputer.Text.ToLower();

            }
            else
            {
                txtOutputComputer.Text = "Schaar";
                keuzePC = txtOutputComputer.Text.ToLower();

            }
            return txtOutputComputer.Text;
        }

        private void WieWint() 
        {
            if (keuze == keuzePC)
            {
                txtMessageWinaar.Text = "Niemand wint!";
                txtOutputComputer.Background = Brushes.Gray;
                txtOutputSpeler.Background = Brushes.Gray;
            }
            else if (keuze == "blad" && keuzePC == "steen") 
            {
                SpelerWintOutput();

            }
            else if (keuze == "steen" && keuzePC == "Schaar")
            {
                SpelerWintOutput();



            }
            else if (keuze == "schaar" && keuzePC == "blad")
            {
                SpelerWintOutput();

            }

            else
            {
                ComputerWint();
            }
        }
        private void SpelerWintOutput() 
        {
            scoreSpeler++;
            txtMessageWinaar.Text = "Speler wint!";
            txtOutputSpeler.Background = Brushes.Green;
            txtOutputComputer.Background = Brushes.Red;
            txtScore.Text = $"Score : {scoreSpeler} - {scoreComputer}";
        }
        private void ComputerWint() 
        {
            scoreComputer++;
            txtMessageWinaar.Text = "De computer wint!";
            txtOutputSpeler.Background = Brushes.Red;
            txtOutputComputer.Background = Brushes.Green;
            txtScore.Text = $"Score : {scoreSpeler} - {scoreComputer}";

        }
        



    }
}
