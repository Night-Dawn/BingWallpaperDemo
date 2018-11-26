using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace BingWallpaper.Models
{
    class ShowTime
    {
        public static DispatcherTimer GetTime()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            return timer;
          
        }

        
    }
}
