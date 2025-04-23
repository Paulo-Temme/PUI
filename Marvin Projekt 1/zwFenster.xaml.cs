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

namespace Marvin_Projekt_1
{
    /// <summary>
    /// Interaktionslogik für zwFenster.xaml
    /// </summary>
    public partial class zwFenster : Window
    {
        private int zahler = 1;
        public zwFenster()
        {
            InitializeComponent();
            GenerateEllipses(0); // Ellipsen in der ersten Spalte generieren
            GenerateRectangless(1); // Rechtecke in der zweiten Spalte generieren
            GenerateEllipses(2); // Ellipsen in der dritten Spalte generieren
            GenerateRectangless(3);


        }


        private void GenerateEllipses(int spalte)
        {
            // Schleife, um 5 Rechtecke zu erstellen
            for (int i = 0; i < 5; i++)
            {
                var ellipse = new Ellipse
                {
                    Width = 50,
                    Height = 50,
                    Fill = new SolidColorBrush(Colors.Red),
                   
                };

                // Rechteck in die entsprechende Zeile und Spalte setzen
                Grid.SetRow(ellipse, i); // Zeile wird durch die Schleife bestimmt
                Grid.SetColumn(ellipse, spalte); // Spalte wird durch den Parameter bestimmt
                Grid.SetColumnSpan(ellipse, 5);

                // Rechteck dem Grid hinzufügen
                maingrid.Children.Add(ellipse);
            }
        }



        private void GenerateRectangless(int spalte)
        {
            // Schleife, um 5 Rechtecke zu erstellen
            for (int i = 0; i < 5; i++)
            {
                var rechteck = new Rectangle
                {
                    Width = 50,
                    Height = 50,
                    Fill = new SolidColorBrush(Colors.Red),
                    
                };

                // Rechteck in die entsprechende Zeile und Spalte setzen
                Grid.SetRow(rechteck, i); // Zeile wird durch die Schleife bestimmt
                Grid.SetColumn(rechteck, spalte); // Spalte wird durch den Parameter bestimmt
                Grid.SetColumnSpan(rechteck, 5);
                // Rechteck dem Grid hinzufügen
                maingrid.Children.Add(rechteck);
            }
        }





    }
}
