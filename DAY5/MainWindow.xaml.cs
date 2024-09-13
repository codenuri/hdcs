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
        
        private double width = 0;
        private double height = 0;

        private int[,] state = new int[COUNT, COUNT]; // 게임판 상태를나타내는
                                                      // 2차원 배열
        public void InitState()
        {
            int k = 0;    
            for ( int y = 0; y < COUNT; ++y)
            {
                for (int x = 0; x < COUNT; ++x)
                    state[y, x] = k++;      // 0 ~ 24 로 채우기
            }
        }

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

            BitmapImage bitmap = new BitmapImage(uri); // 전체 그림

            // 블럭 한개 크기
            width  = bitmap.Width / COUNT;
            height = bitmap.Height / COUNT;


            for (int y = 0; y < COUNT; y++)
            {
                for (int x = 0; x < COUNT; x++)
                {

                    if (state[y, x] != EMPTY)
                    {
                        // 0~24 중 8번 블럭을 그리려면
                        // => x로 3번째, y로 1번째 라는 것을 알아야 합니다. 
                        int bx = state[y, x] % COUNT;  // 3
                        int by = state[y, x] / COUNT;  // 1

                        CroppedBitmap crop = new CroppedBitmap(bitmap,
                                             new Int32Rect(bx * (int)width, by * (int)height,
                                                          (int)width, (int)height));


                        Image img = new Image { Source = crop };

                        img.Stretch = Stretch.Fill;
                        img.Margin = new Thickness(0.5);

                        Grid.SetRow(img, y);
                        Grid.SetColumn(img, x);

                        gameGrid.Children.Add(img);
                    }
                }
            }


        }



        public MainWindow()
        {
            InitializeComponent();
            InitGrid();
            InitState();
            DrawGrid();
        }
    }
}