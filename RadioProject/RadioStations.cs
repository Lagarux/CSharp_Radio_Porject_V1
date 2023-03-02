using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioProject
{
    internal static class RadioStations
    {
       internal static Dictionary<int,string> stations=new Dictionary<int, string>()
        {
            {0,"http://37.247.98.8/stream/166/" },
            {1,"https://cdn3.akradyo.net/akracanli2/_definst_/livestream_aac/playlist.m3u8" },
            {2,"https://radyo.duhnet.tv/dreamturk" },
            {3,"https://live.radyofenomen.com/fenomen/128/icecast.audio" },
            {4,"http://dijimedya.radyotvonline.net/gncradyo" },
            {5,"http://yayin.radyohayalfm.net:8050/?type=http&nocache=41963" },
            {6,"https://23563.live.streamtheworld.com/JOY_TURK_SC" },
            {7,"https://moondigitalmaster.radyotvonline.net/kentfm/playlist.m3u8" },
            {8,"http://212.175.65.102:8001/live" },
            {9,"http://46.20.3.204/" },
            {10,"http://46.20.3.201/" },
            {11,"http://radyomgm.canliyayinda.com/" },
            {12,"https://n10101m.mediatriple.net/trrap" },
            {13,"https://n10101m.mediatriple.net/numberone" },
            {14,"http://ntvrdwmp.radyotvonline.com/" },
            {15,"https://live.powerapp.com.tr/powerturk/abr/powerturk/128/playlist.m3u8" },
            {16,"https://m.egm.gov.tr:8093//;?type=http&amp;nocache=1/;stream.mp3" }
        };

        internal static List<Tuple<int,string, string>> stationsImage = new List<Tuple<int,string, string>>()
        {
            new Tuple<int,string, string>(0,"90'LAR",@"C:\\Users\\ttt-g\\Desktop\\WSTE\\Visual_Studio\\Asp.Net\\RadioProject\\RadioProject\\Res\\radyo-doksanlar-dinle.jpg"),
            new Tuple<int,string,string>(1,"Akra FM",@"C:\\Users\\ttt-g\\Desktop\\WSTE\\Visual_Studio\\Asp.Net\\RadioProject\\RadioProject\\Res\\akra-logo2.png"),
            new Tuple<int,string,string>(2,"Dreamtürk",@"C:\\Users\\ttt-g\\Desktop\\WSTE\\Visual_Studio\\Asp.Net\\RadioProject\\RadioProject\\Res\\tr-dream-turk.jpg"),
            new Tuple<int,string,string>(3,"Radyo Fenomen",@"C:\\Users\\ttt-g\\Desktop\\WSTE\\Visual_Studio\\Asp.Net\\RadioProject\\RadioProject\\Res\\RadyoFenomen.png"),
            new Tuple<int,string,string>(4,"Genç Radyo",@"C:\Users\ttt-g\Desktop\WSTE\Visual_Studio\Asp.Net\RadioProject\RadioProject\Res\\gncradyo.png"),
            new Tuple<int,string,string>(5,"Radyo Hayal",@"C:\Users\ttt-g\Desktop\WSTE\Visual_Studio\Asp.Net\RadioProject\RadioProject\Res\\RadyoHayal.png"),
            new Tuple<int,string,string>(6,"JOY TÜRK",@"C:\Users\ttt-g\Desktop\WSTE\Visual_Studio\Asp.Net\RadioProject\RadioProject\Res\\JoyTurk.jpg"),
            new Tuple<int,string,string>(7,"Kent FM",@"C:\Users\ttt-g\Desktop\WSTE\Visual_Studio\Asp.Net\RadioProject\RadioProject\Res\\KentFM.png"),
            new Tuple<int,string,string>(8,"Konya TV",@"C:\Users\ttt-g\Desktop\WSTE\Visual_Studio\Asp.Net\RadioProject\RadioProject\Res\\konya-fm.jpg"),
            new Tuple<int,string,string>(9,"KRAL FM",@"C:\Users\ttt-g\Desktop\WSTE\Visual_Studio\Asp.Net\RadioProject\RadioProject\Res\\kralfm.png"),
            new Tuple<int,string,string>(10,"KRAL POP",@"C:\Users\ttt-g\Desktop\WSTE\Visual_Studio\Asp.Net\RadioProject\RadioProject\Res\\kralpop.png"),
            new Tuple<int,string,string>(11,"METEOROLOJİ GENEL MÜDÜRLÜĞÜ RADYOSU",@"C:\Users\ttt-g\Desktop\WSTE\Visual_Studio\Asp.Net\RadioProject\RadioProject\Res\\MGM_Radyo.png"),
            new Tuple<int,string,string>(12,"NUMBER ONE TÜRK RAP",@"C:\Users\ttt-g\Desktop\WSTE\Visual_Studio\Asp.Net\RadioProject\RadioProject\Res\\nr1rap.jpg"),
            new Tuple<int,string,string>(13,"NUMBER ONE FM",@"C:\Users\ttt-g\Desktop\WSTE\Visual_Studio\Asp.Net\RadioProject\RadioProject\Res\\nr1fm.png"),
            new Tuple<int,string,string>(14,"NTV RADYO",@"C:\Users\ttt-g\Desktop\WSTE\Visual_Studio\Asp.Net\RadioProject\RadioProject\Res\\ntvradyo.png"),
            new Tuple<int,string,string>(15,"POWERTÜRK FM",@"C:\Users\ttt-g\Desktop\WSTE\Visual_Studio\Asp.Net\RadioProject\RadioProject\Res\\powerTurk.png"),
            new Tuple<int,string,string>(16,"POLİS RADYOSU",@"C:\Users\ttt-g\Desktop\WSTE\Visual_Studio\Asp.Net\RadioProject\RadioProject\Res\\polisR.jpg"),
        };


    }
}
