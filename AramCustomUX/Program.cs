using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AramCustomUX {
    static class Program {

        public static string champsString = @"Aatrox,Ahri,Akali,Alistar,Amumu,Anivia,Annie,Aphelios,Ashe,
                                        AurelionSol,Azir,Bard,Blitzcrank,Brand,Braum,Caitlyn,Camille,
                                        Cassiopeia,Chogath,Corki,Darius,Diana,Draven,DrMundo,Ekko,Elise,
                                        Evelynn,Ezreal,Fiddlesticks,Fiora,Fizz,Galio,Gangplank,Garen,Gnar,
                                        Gragas,Graves,Hecarim,Heimerdinger,Illaoi,Irelia,Ivern,Janna,
                                        JarvanIV,Jax,Jayce,Jhin,Jinx,Kaisa,Kalista,Karma,Karthus,Kassadin,
                                        Katarina,Kayle,Kayn,Kennen,Khazix,Kindred,Kled,KogMaw,Leblanc,
                                        LeeSin,Leona,Lillia,Lissandra,Lucian,Lulu,Lux,Malphite,Malzahar,
                                        Maokai,MasterYi,MissFortune,Mordekaiser,Morgana,Nami,Nasus,Nautilus,
                                        Neeko,Nidalee,Nocturne,Nunu,Olaf,Orianna,Ornn,Pantheon,Poppy,Pyke,
                                        Qiyana,Quinn,Rakan,Rammus,RekSai,Rell,Renekton,Rengar,Riven,Rumble,
                                        Ryze,Samira,Sejuani,Senna,Seraphine,Sett,Shaco,Shen,Shyvana,Singed,
                                        Sion,Sivir,Skarner,Sona,Soraka,Swain,Sylas,Syndra,TahmKench,Taliyah,
                                        Talon,Taric,Teemo,Thresh,Tristana,Trundle,Tryndamere,TwistedFate,
                                        Twitch,Udyr,Urgot,Varus,Vayne,Veigar,VelKoz,Vi,Viego,Viktor,Vladimir,
                                        Volibear,Warwick,Wukong,Xayah,Xerath,XinZhao,Yasuo,Yone,Yorick,Yuumi,
                                        Zac,Zed,Ziggs,Zilean,Zoe,Zyra";

        public static List<string> champs = new List<string>();
        public static List<string> AbannedChamps = new List<string>();
        public static List<string> BbannedChamps = new List<string>();
        public static List<string> GlobalBannedChamps = new List<string>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {

            string champsString = Program.champsString;
            champsString = champsString.Replace(Environment.NewLine, "");
            champsString = champsString.Replace(" ", "");
            champs = new List<string>(champsString.Split(','));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
