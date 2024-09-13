using System.Media;
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

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point pt = e.GetPosition(gameGrid);

            int bx = (int)(pt.X / (gameGrid.ActualWidth / COUNT));
            int by = (int)(pt.Y / (gameGrid.ActualHeight / COUNT));


            if (bx < 0 || by < 0 || bx >= COUNT || by >= COUNT) return;

            if (bx < COUNT - 1 && state[by, bx + 1] == EMPTY) // RIGHT 가
            {
                SwapBlock(bx, by, bx + 1, by);
            }
            else if (bx > 0 && state[by, bx - 1] == EMPTY) // Left 가
            {
                SwapBlock(bx, by, bx - 1, by);
            }
            else if (by < COUNT - 1 && state[by + 1, bx] == EMPTY)
            {
                SwapBlock(bx, by, bx, by + 1);
            }
            else if (by > 0 && state[by - 1, bx] == EMPTY)
            {
                SwapBlock(bx, by, bx, by - 1);
            }
            else
            {
                SystemSounds.Beep.Play();
                return;
            }
            // 다 맞추었는지 확인
        }

        public void SwapBlock(int x1, int y1, int x2, int y2)
        {
            // 배열값 교환
            int temp = state[y1, x1];
            state[y1, x1] = state[y2, x2];
            state[y2, x2] = temp;

            // grid 내부의 image 교환
            Image img1 = gameGrid.Children.Cast<Image>().FirstOrDefault(n => Grid.GetRow(n) == y1 && Grid.GetColumn(n) == x1);
            Image img2 = gameGrid.Children.Cast<Image>().FirstOrDefault(n => Grid.GetRow(n) == y2 && Grid.GetColumn(n) == x2);

            if (img1 != null)
            {
                Grid.SetRow(img1, y2);
                Grid.SetColumn(img1, x2);
            }
            if (img2 != null)
            {
                Grid.SetRow(img2, y1);
                Grid.SetColumn(img2, x1);
            }
        }
    }
}