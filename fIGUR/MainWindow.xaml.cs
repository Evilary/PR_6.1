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
using fIGUR.Classes;

namespace fIGUR
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DrawFigures();
            
        }

        void DrawFigures()
        {
            Treugol treugol1 = new Treugol(50, 150, 250);
            treugol1.Draw(Can);

            Krug krug1 = new Krug(150, 150, 150);
            krug1.Draw(Can);

        }
    }
}
