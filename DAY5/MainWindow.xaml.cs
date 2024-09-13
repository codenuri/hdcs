﻿using System.Runtime.InteropServices;
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

        private double width = 0;
        private double height = 0;

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
                    CroppedBitmap crop = new CroppedBitmap(bitmap,
                                         new Int32Rect(x * (int)width, y * (int)height, 
                                                      (int)width, (int)height));


                    Image img = new Image { Source = crop };

                    Grid.SetRow(img, y);
                    Grid.SetColumn(img, x);

                    gameGrid.Children.Add(img);
                }
            }


        }



        public MainWindow()
        {
            InitializeComponent();
            InitGrid();
            DrawGrid();
        }
    }
}