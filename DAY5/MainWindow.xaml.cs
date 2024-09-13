using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SlidingPuzzle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int COUNT = 5;
        private const int EMPTY = COUNT * COUNT - 1;

        public void InitGrid()
        {
            for( int i = 0; i < COUNT; i++ )
            {
                gameGrid.RowDefinitions.Add(new RowDefinition());
                gameGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }
        }

        public void DrawGrid()
        {
            Uri uri = new Uri("D:\\totoro.jpeg"); // 어제 다운 받은 그림사용

            BitmapImage bitmap = new BitmapImage(uri);

            Image img = new Image { Source = bitmap };

            Grid.SetRow(img, 0);
            Grid.SetColumn(img, 0);

            gameGrid.Children.Add(img);
        }
        public MainWindow()
        {
            InitializeComponent();
            InitGrid();
            DrawGrid();
        }
    }
}