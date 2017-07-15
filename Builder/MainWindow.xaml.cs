using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Builder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Pen p = new Pen(Color.Yellow);
            
            //PersonThinBuilder ptb = new PersonThinBuilder(null, p);
            //PersonDirector pdthin = new PersonDirector(ptb);
            //pdthin.CreatePerson();

            System.Windows.Media.SolidColorBrush brush = new SolidColorBrush(Colors.Blue);
            
            System.Windows.Media.SolidColorBrush brush2 = new SolidColorBrush(Colors.Yellow);

            Ellipse ellipse = new Ellipse();
            ellipse.Stroke = brush;
            ellipse.Height = 200;
            ellipse.Width = 200;
            ellipse.Fill = brush2;
            
            canvas.Children.Add(ellipse);
        }
    }
}
