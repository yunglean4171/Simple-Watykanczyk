using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using Microsoft.Win32;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;

namespace watykańczyk
{
    class Program
    {
        [STAThread]

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
        
        //sposoby ustawienia tapety
        public enum Style : int
        {
            Tiled,
            Centered,
            Stretched
        }


        static void Main(string[] args)
        {
        string plik = "papaj.txt";
        string kodcl = @"Niekwestionowana na świecie jest opinia, że wybór Polaka, Karola Wojtyły na papieża, a następnie jego pontyfikat, w dużej mierze przyczyniły się do obalenia komunizmu w Europie Środkowo-Wschodniej i powrotu wolności i demokracji w tym regionie świata.

Karol Wojtyła urodził się w Wadowicach. W 1929 r. zmarła jego matka – Emilia z Kaczorowskich. W 1938 r., po uzyskaniu świadectwa dojrzałości w wadowickim gimnazjum, wraz z ojcem, Karolem, przeniósł się do Krakowa, gdzie rozpoczął studia polonistyczne na Wydziale Filologicznym Uniwersytetu Jagiellońskiego.

Po wybuchu II wojny światowej i zamknięciu uczelni zaczął pracować jako robotnik w kamieniołomach na Zakrzówku w Krakowie, a następnie w zakładach chemicznych w Borku Fałęckim pod Krakowem. Wspomnienia z tego okresu można odnaleźć w jednym z jego pierwszych utworów literackich, poemacie „Kamień i bezmiar”, który był podpisany pseudonimem Andrzej Jawień. W 1941 r. zmarł ojciec Karola Wojtyły. 

Podczas okupacji razem z Mieczysławem Kotlarczykiem, przyjacielem z Wadowic, zorganizował w Krakowie konspiracyjny Teatr Rapsodyczny; był jednym z pierwszych jego aktorów i reżyserów. W repertuarze znajdowały się adaptacje dzieł wybitnych polskich klasyków.

W 1942 r. wstąpił do konspiracyjnego Arcybiskupiego Seminarium Duchownego w Krakowie. Równolegle studiował filozofię na tajnym Wydziale Teologicznym Uniwersytetu Jagiellońskiego.

Od 1 sierpnia 1944 do 18 stycznia 1945 r. (do wejściu do Krakowa Armii Czerwonej), ukrywał się wraz z kolegami w pałacu metropolity krakowskiego kard. Adama Stefana Sapiehy.

1 listopada 1946 r., po ukończeniu studiów teologicznych, otrzymał święcenia kapłańskie. Później przez dwa lata kontynuował studia filozoficzne w Rzymie. Przebywał również we Francji, w Belgii i Holandii, prowadząc pracę duszpasterską wśród Polonii. Utrzymywał przy tym żywe kontakty z ruchem Jeunesse Ouvrière Chrétienne (Robotnicza Młodzież Chrześcijańska).

Po powrocie do kraju w 1948 r. został wikariuszem w parafii w Niegowici, w powiecie bocheńskim, a w 1949 r. – w parafii św. Floriana w Krakowie. 
Przygotowywał na Wydziale Teologicznym UJ pracę doktorską pt. „Problemy wiary w pismach św. Jana od Krzyża”, którą obronił w 1948 r. Pięć lat później obronił habilitację na Wydziale Teologicznym UJ na podstawie rozprawy „O możliwości zbudowania etyki katolickiej w oparciu o system Maxa Schelera” (rozprawa ukazała się drukiem w 1959). 

W 1953 r. został wykładowcą teologii moralnej i etyki społecznej w krakowskim Seminarium Duchownym, a w następnym roku rozpoczął pracę na Wydziale Filozoficznym Katolickiego Uniwersytetu Lubelskiego jako kierownik Katedry i Zakładu Etyki. W 1956 r. został zastępcą profesora tej uczelni, a po roku otrzymał docenturę. W latach 1958–1978 był wykładowcą na KUL.

W lipcu 1958 r. papież Pius XII mianował go biskupem tytularnym – biskupem pomocniczym abp. archidiecezji krakowskiej, Eugeniusza Baziaka. Sakrę biskupią Karol Wojtyła otrzymał 28 września w bazylice na Wawelu. W wieku 38 lat został najmłodszym członkiem Episkopatu Polski. Po śmierci abp. Baziaka Kapituła Metropolitalna wybrała go w czerwcu 1962 r. na stanowisko wikariusza kapitulnego Archidiecezji Krakowskiej. Rok później, w grudniu 1963 r., został mianowany przez papieża Pawła VI arcybiskupem metropolitą krakowskim, w czerwcu 1967 r. otrzymał zaś kapelusz kardynalski. 

Od 1969 r. w Episkopacie Polski pełnił przez wiele lat m.in. funkcję wiceprzewodniczącego Konferencji Episkopatu i przewodniczącego Komisji Rady Naukowej Episkopatu. Równocześnie był członkiem watykańskich Kongregacji ds. Kościołów Wschodnich, ds. Duchowieństwa i ds. Kultu Bożego. 
Brał również aktywny udział w pracach II Soboru Watykańskiego (1962–1965), uczestnicząc we wszystkich czterech sesjach, m.in. jako członek komisji opracowującej i ostatecznie redagującej tzw. schemat XIII, czyli tekst konstytucji „O obecności Kościoła w świecie współczesnym”. Uczestniczył też w redagowaniu konstytucji „O Kościele”, deklaracji „O wolności religijnej” oraz dekretu „O apostolstwie świeckim”.

Jesienią 1969 r. odbył półtoramiesięczną podróż do Kanady i Stanów Zjednoczonych, odwiedzając mieszkających tam rodaków. Spotkał się też z członkami hierarchii kościelnej obu krajów.

Z nominacji papieża Pawła VI został członkiem Komisji Soborowej dla Apostolstwa Świeckiego. Na nadzwyczajnym zgromadzeniu Synodu Biskupów w październiku 1969 r. przedstawił projekt dokumentu „II Nadzwyczajny Synod Biskupów o sobie”, określanego powszechnie jako dokument Wojtyły.

W 1973 r. uczestniczył w Kongresie Eucharystycznym w Melbourne, odwiedził także polskich misjonarzy na Nowej Gwinei i polskie skupiska w Australii, Nowej Zelandii i Tasmanii. Trzy lata później wziął udział w Kongresie Eucharystycznym w Filadelfii. Był członkiem Stałej Rady Sekretariatu Światowego Synodu Biskupów jako przedstawiciel Europy. 

W marcu 1976 r. został zaproszony specjalnie przez Pawła VI, aby prowadzić w Watykanie doroczne rekolekcje. We wrześniu 1978 r. wchodził w skład delegacji Episkopatu Polski rewizytującej Episkopat RFN.

16 października 1978 r. konklawe wybrało arcybiskupa i metropolitę Krakowa, 58-letniego kard. Karola Wojtyłę na papieża – 264. z kolei zwierzchnika Kościoła katolickiego. Przybrał imię Jan Paweł II na znak symbolicznej kontynuacji przerwanego nagłą śmiercią 33-dniowego pontyfikatu swego poprzednika, Jana Pawła I. 

Wybór krakowskiego metropolity na papieża był zaskoczeniem dla całego świata, ponieważ po raz pierwszy od 455 lat na Stolicy Apostolskiej zasiadł biskup nie-Włoch. Zaskoczenie było tym większe, że nowy biskup Rzymu pochodził ze słowiańskiego kraju, który w tamtym czasie należał do bloku sowieckiego.

W pierwszą pielgrzymkę zagraniczną Jan Paweł II wyruszył do Meksyku. Z kolei pierwszą pielgrzymkę do ojczyzny odbył w dniach 2–10 czerwca 1979 r. Miała ona znaczenie nie tylko dla wolności Kościoła w zniewolonym kraju, lecz również pośrednio przyczyniła się do odzyskania przez Polskę swobód demokratycznych. Zdaniem wielu analityków to, co papież wówczas mówił, miało wpływ na powstanie „Solidarności”. Podczas mszy na pl. Zwycięstwa w Warszawie (2 czerwca) padły historyczne dziś słowa: „I wołam, ja, syn polskiej ziemi, a zarazem ja, Jan Paweł II, papież, wołam z całej głębi tego tysiąclecia, wołam w przeddzień święta Zesłania, wołam wraz z wami wszystkimi: niech zstąpi Duch Twój! Niech zstąpi i odnowi oblicze ziemi. Tej ziemi!”.

Jan Paweł II przybył do Polski łącznie dziewięć razy. Daty kolejnych pielgrzymek to: 16–23 czerwca 1983, 8–14 czerwca 1987, 1–9 czerwca i 13–20 sierpnia 1991, 22 maja 1995, 31 maja–10 czerwca 1997, 5–17 czerwca 1999 i 16–19 sierpnia 2002 r. 

Po niespełna trzech pierwszych, niezwykle intensywnych latach pontyfikatu 13 maja 1981 r. papież został ciężko ranny w zamachu na placu św. Piotra, gdzie strzały do niego oddał turecki zamachowiec Mehmet Ali Ağca. Jan Paweł II trafił do kliniki Gemelli w stanie krytycznym. Został uratowany, mimo że sami lekarze wątpili, czy przeżyje. W grudniu 1983 r. papież odwiedził Ağcę w więzieniu w Rzymie.

Podczas swej ponad-26-letniej posługi Jan Paweł II ogłosił 14 encyklik. „Redemptor hominis” („Odkupiciel człowieka”) jest pierwszą, programową encykliką, ogłoszoną w marcu 1979 r. Program pontyfikatu papież streścił w zdaniu: „Człowiek jest pierwszą i podstawową drogą Kościoła”. W tym dokumencie podkreślił „niezbywalną godność i wartość każdej osoby ludzkiej bez względu na jej wyznanie czy kulturę”. W 1980 r. została ogłoszona encyklika „Dives in misericordia” („O Bożym miłosierdziu”), która w głównej mierze została poświęcona znaczeniu problematyki miłosierdzia Bożego i moralności chrześcijańskiej. 

W 1981 r. ukazała się „Laborem exercens” („O pracy ludzkiej”). Została w niej zawarta analiza problematyki pracy ludzkiej we współczesnym świecie. Z kolei „Slavorum Apostoli” („Apostołowie Słowian”) z 1985 r. została poświęcona dziełom misyjnym Kościoła. W kolejnej encyklice – „Dominum et Vivificantem” („O Duchu Świętym w życiu Kościoła i świata”) – ogłoszonej w 1986 r. papież nawiązał do wiary Kościoła sformułowanej na Soborze Powszechnym w Konstantynopolu w 381 r. i wyznawanej do dzisiaj w Credo.

W 1987 r. w encyklice „Redemptoris Mater” („Matka Odkupiciela”) ukazał centralne miejsce i rolę Maryi w Kościele. Natomiast w ogłoszonej w 1987 r. „Sollicitudo rei socialis” („Troska o sprawy społeczne”) skoncentrował się na kwestiach społecznych. W 1990 r. ukazała się „Redemptoris Missio” („Misja Odkupiciela”), w której omówił teologiczne podstawy ewangelizacji. Natomiast w 1991 r. ukazała się encyklika „Centesimus annus” („W setną rocznicę encykliki +Rerum Novarum+”). Została ona poświęcona załamaniu się ideologii marksistowskiej i upadkowi systemu komunistycznego. 

„Veritatis splendor” („Blask prawdy”) została ogłoszona w 1993 r. i omawia zagadnienia moralne. Z kolei w „Evangelium vitae” („Ewangelia życia”) z 1995 r. Jan Paweł II broni wartości, a także nienaruszalności życia ludzkiego. Natomiast encyklikę „Ut unum sint” („Aby byli jedno”) z 1995 r. papież poświęcił działalności ekumenicznej. W roku 1998 ukazała się „Fides et ratio” („Wiara i rozum”) ukazująca relacje zachodzące między wiarą a rozumem. Natomiast ostatnią encyklikę – „Ecclesia in Eucharistia” („O Eucharystii w życiu Kościoła”) – Jan Paweł II ogłosił w 2003 r. 

Jan Paweł II ogłosił 14 adhortacji, 11 konstytucji apostolskich, 43 listy apostolskie. Zwołał dziewięć konsystorzy, mianował ok. 240 kardynałów (w tym pięciu Polaków) i 2,5 tys. biskupów, wyświęcił ponad 2 tys. księży, kanonizował 482 błogosławionych (w tym 10 Polaków), beatyfikował 1318 osób (w tym 154 Polaków). Przewodniczył pięciu posiedzeniom plenarnym kolegium kardynalskiego, sześciu zgromadzeniom generalnym zwyczajnym synodu biskupów, jednemu zgromadzeniu nadzwyczajnemu synodu biskupów, siedmiu zgromadzeniom specjalnym synodu biskupów. Przyjął ok. 1400 osobistości politycznych oraz wygłosił ok. 4 tys. przemówień (w tym 2,5 tys. za granicą).

Odbył 104 apostolskie podróże do 132 krajów, a w ich trakcie odwiedził 900 miast i miejscowości. Pielgrzymki do najodleglejszych geograficznie, religijnie i światopoglądowo krajów wyznaczyły cały rytm i program pontyfikatu, a także jego najważniejsze wydarzenia, zwłaszcza zaś były impulsem do historycznych gestów papieża, wyrażających wolę dialogu, pojednania i wyciągnięcia ręki. 

Jako pierwszy papież w dziejach Jan Paweł II odwiedził kościół luterański (1983), synagogę (1986) i meczet (2000). W 1986 r. mimo sprzeciwu i zastrzeżeń niektórych kościelnych dostojników zaprosił przedstawicieli wszystkich wyznań i religii do Asyżu na wspólną modlitwę o pokój. Za nieocenione uważa się jego zasługi dla dialogu katolicko-żydowskiego; dokonał także ważnego otwarcia wobec prawosławia.

Choć przedmiotem niemijających dyskusji jest to, do jakiego stopnia „sojusz” polskiego papieża z prezydentem USA Ronaldem Reaganem faktycznie doprowadził do obalenia komunizmu, nie ulega wątpliwości to, że jego słowa oraz gesty stanowiły inspirację dla demokratycznej opozycji w Polsce i innych krajach bloku wschodniego. Wydarzeniem przełomowym w kontaktach z Moskwą było pierwsze spotkanie Jana Pawła II z ówczesnym sowieckim przywódcą Michaiłem Gorbaczowem 1 grudnia 1989 r. w Watykanie. Niezwykle ważną polityczną wymowę miała papieska pielgrzymka na Kubę w 1998 r., choć nie przyniosła ona takich zmian, jakich oczekiwano.

Jan Paweł II zgromadził wokół siebie miliony młodych katolików, ustanawiając w 1985 r. Światowe Dni Młodzieży, które stały się największymi masowymi, regularnymi uroczystościami z jego udziałem.

Do historii przeszło też jego niezwykle poruszające przemówienie, jakie wygłosił (wręcz wykrzyczał) w Agrigento na Sycylii, gdy wezwał członków mafii, by się nawrócili. 12 marca 2000 r. wykonał jako pierwszy papież w dziejach gest „mea culpa”, określany wręcz jako „niesłychany”. Prosił o wybaczenie krzywd wyrządzonych przez synów i córki Kościoła przedstawicielom innych religii.

Jan Paweł II zmarł 2 kwietnia 2005 r. 1 maja 2011 został beatyfikowany przez Benedykta XVI, a 27 kwietnia 2014 r. kanonizowany przez papieża Franciszka. (PAP)";

        string result = Path.GetTempPath();

            bool started = true;

            while (started)
                {
                //ukrywanie konsoli po starcie watykańczyka
                var handle = GetConsoleWindow();
                ShowWindow(handle, SW_HIDE);
                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile("https://i.imgur.com/fmeXf1c.jpg", string.Format(result + "\\papiezak.jpg", Guid.NewGuid().ToString()));
                }
                //ustawianie tapety z papajem
                //Set(result + "\\papiezak.jpg", Style.Stretched);

                 if (!File.Exists(plik))
                 {
                     File.Create(plik).Dispose();

                     using (TextWriter tw = new StreamWriter(plik))
                     {
                         tw.WriteLine(kodcl);
                     }

                 }
                 else if (File.Exists(plik))
                 {
                     using (TextWriter tw = new StreamWriter(plik))
                     {
                         tw.WriteLine(kodcl);
                     }
                 }

                MessageBox.Show("get papieżed");

                System.Diagnostics.Process.Start(plik);
                
                //odpalanie nutek
                bomba();
            }
            void bomba()
            {

                //odpalanie paru klimatycznych nutek
                SoundPlayer nuta1 = new SoundPlayer(watykańczyk.Properties.Resources.shuffle);
                nuta1.Play();
                Thread.Sleep(105000);
                SoundPlayer nuta2 = new SoundPlayer(watykańczyk.Properties.Resources.wapiesz);
                nuta2.Play();
                Thread.Sleep(180000);
                SoundPlayer nuta3 = new SoundPlayer(watykańczyk.Properties.Resources.aliagca);
                nuta3.Play();
                //odpalanie barki techno remix
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=1dOt_VcbgyA");
            }

            void Set(string imgPath, Style style)
            {
                var img = Image.FromFile(Path.GetFullPath(imgPath));
                string tempPath = Path.Combine(Path.GetTempPath(), "wallpaper.bmp");
                img.Save(tempPath, ImageFormat.Bmp);

                var key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);

                switch (style)
                {
                    case Style.Tiled:
                        key.SetValue(@"WallpaperStyle", 1.ToString());
                        key.SetValue(@"TileWallpaper", 1.ToString());
                        break;
                    case Style.Centered:
                        key.SetValue(@"WallpaperStyle", 1.ToString());
                        key.SetValue(@"TileWallpaper", 0.ToString());
                        break;
                    case Style.Stretched:
                        key.SetValue(@"WallpaperStyle", 2.ToString());
                        key.SetValue(@"TileWallpaper", 0.ToString());
                        break;
                    default:
                        break;
                }

                SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, tempPath, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
            }
        }
    }
}

