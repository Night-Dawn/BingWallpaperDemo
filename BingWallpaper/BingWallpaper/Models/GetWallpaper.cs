using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using static BingWallpaper.Models.WallpaperData;

namespace BingWallpaper.Models
{
    public  class GetWallpaper
    {
        public static async Task<Rootobject> GetRootobjectAsync(int idn)
        {
            string idx = idn.ToString();
            HttpClient http = new HttpClient();
            string uri = String.Format($"https://cn.bing.com/HPImageArchive.aspx?format=js&idx={idx}&n=1&mkt=zh-CN");
            var respone = await http.GetAsync(uri);
            var result = await respone.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(Rootobject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (Rootobject)serializer.ReadObject(ms);
            return data;
        }
    }
}
