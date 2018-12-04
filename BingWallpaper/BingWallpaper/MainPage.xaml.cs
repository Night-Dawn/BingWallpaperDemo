using BingWallpaper.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using static BingWallpaper.Models.WallpaperData;
// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace BingWallpaper
{

    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>

    public sealed partial class MainPage : Page
    {
        public static MainPage Current;
        public MainPage()
        {
            this.InitializeComponent();
            Current = this;
        }
       
        //传入api中获取对应天数的壁纸

        private async void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            var   rootobject = await GetWallpaper.GetRootobjectAsync(0);
            string url = String.Format($"https://cn.bing.com{rootobject.images[0].url}");
            MyImage.Source = new BitmapImage(new Uri(url, UriKind.Absolute));
            copyrightTextBlock.Text = rootobject.images[0].copyright;
            var timer = ShowTime.GetTime();
            timer.Tick += Timer_Tick;
            timer.Start();
            
        }

        private void Timer_Tick(object sender, object e)
        {
            this.timeTextBlock.Text = DateTime.Now.ToString();
        }

        private void Grid_Loading(FrameworkElement sender, object args)
        {
            MyImage.Source = new BitmapImage(new Uri("ms-appx:Assets/welcome.png"));

        }

        private void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            showMorePicture.Begin();
        }

        private void Grid_Tapped(object sender, TappedRoutedEventArgs e)
        {
            showMorePicture.Stop();
        }
        public int day = 0;
        public  async void Minus_bar_Click(object sender, RoutedEventArgs e)
        {
            plus_bar.IsEnabled = true;
                day++;
            if (day > 7)
                day = 7;
                
                switch(day)
                {
                    case 0:
                        DayNumber.Text = "今天";
                        break;
                    case 1:
                        DayNumber.Text = "昨天";
                        break;
                    case 2:
                        DayNumber.Text = "两天前";
                        break;
                    case 3:
                        DayNumber.Text = "三天前";
                        break;
                    case 4:
                        DayNumber.Text = "四天前";
                        break;
                    case 5:
                        DayNumber.Text = "五天前";
                        break;
                    case 6:
                        DayNumber.Text = "六天前";
                        break;
                    case 7:
                        DayNumber.Text = "七天前";
                        minus_bar.IsEnabled = false;
                    break;
                    default:
                        minus_bar.IsEnabled = false;
                        break;
                }
                var rootobject = await GetWallpaper.GetRootobjectAsync(day);
                string url = String.Format($"https://cn.bing.com{rootobject.images[0].url}");
                MyImage.Source = new BitmapImage(new Uri(url, UriKind.Absolute));
                copyrightTextBlock.Text = rootobject.images[0].copyright;
            
            
            
        }

        public async void Plus_bar_Click(object sender, RoutedEventArgs e)
        {
            minus_bar.IsEnabled = true;
            if (day==0)
            {
                DayNumber.Text = "明天";
                var rootobject = await GetWallpaper.GetRootobjectAsync(-1);
                string url = String.Format($"https://cn.bing.com{rootobject.images[0].url}");
                MyImage.Source = new BitmapImage(new Uri(url, UriKind.Absolute));
                copyrightTextBlock.Text = rootobject.images[0].copyright;
                plus_bar.IsEnabled = false;
            }
            else
            {
                plus_bar.IsEnabled = true;
                day--;
                switch (day)
                {
                    case 0:
                        DayNumber.Text = "今天";
                        break;
                    case 1:
                        DayNumber.Text = "昨天";
                        break;
                    case 2:
                        DayNumber.Text = "两天前";
                        break;
                    case 3:
                        DayNumber.Text = "三天前";
                        break;
                    case 4:
                        DayNumber.Text = "四天前";
                        break;
                    case 5:
                        DayNumber.Text = "五天前";
                        break;
                    case 6:
                        DayNumber.Text = "六天前";
                        break;
                    case 7:
                        DayNumber.Text = "七天前";
                        break;
                }
                var rootobject = await GetWallpaper.GetRootobjectAsync(day);
                string url = String.Format($"https://cn.bing.com{rootobject.images[0].url}");
                MyImage.Source = new BitmapImage(new Uri(url, UriKind.Absolute));
                copyrightTextBlock.Text = rootobject.images[0].copyright;
            }
        }
    }
}
