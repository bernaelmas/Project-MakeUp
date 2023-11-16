using System.Windows.Forms;
using UrunSinif;

namespace ProjeFrontDeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tenCbox.CheckedChanged += CheckBox_CheckedChanged;
            gozCbox.CheckedChanged += CheckBox_CheckedChanged;
            dudakCbox.CheckedChanged += CheckBox_CheckedChanged;
            tirnakCbox.CheckedChanged += CheckBox_CheckedChanged;

            fondotenCbox.CheckedChanged += CheckBox_CheckedChanged;
            kapaticiCbox.CheckedChanged += CheckBox_CheckedChanged;
            allikCbox.CheckedChanged += CheckBox_CheckedChanged;

            farCbox.CheckedChanged += CheckBox_CheckedChanged;
            eyelinerCbox.CheckedChanged += CheckBox_CheckedChanged;
            maskaraCbox.CheckedChanged += CheckBox_CheckedChanged;

            dParlaCbox.CheckedChanged += CheckBox_CheckedChanged;
            dKalemCbox.CheckedChanged += CheckBox_CheckedChanged;
            rujCbox.CheckedChanged += CheckBox_CheckedChanged;

            bakimCbox.CheckedChanged += CheckBox_CheckedChanged;
            asetonCbox.CheckedChanged += CheckBox_CheckedChanged;
            ojeCbox.CheckedChanged += CheckBox_CheckedChanged;

            maybellineCbox.CheckedChanged += CheckBox_CheckedChanged;
            lorealCbox.CheckedChanged += CheckBox_CheckedChanged;
            goldenCbox.CheckedChanged += CheckBox_CheckedChanged;
            flormarCbox.CheckedChanged += CheckBox_CheckedChanged;
            wetCbox.CheckedChanged += CheckBox_CheckedChanged;
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Filtrele();
        }
        private void Filtrele()
        {
            List<Urun> urunList = new List<Urun>()
            {
                new Urun("Maybelline", "Ten", "Fond�ten", "A��k"),
                new Urun("Golden Rose", "Ten", "Fond�ten", "Orta"),
                new Urun("L'Oreal Paris", "Ten", "Fond�ten", "Koyu"),
                new Urun("Maybelline", "Ten", "Kapat�c�", "A��k"),
                new Urun("Wet'n Wild", "Ten", "Kapat�c�", "Orta"),
                new Urun("Flormar", "Ten", "Kapat�c�", "Koyu"),
                new Urun("Golden Rose", "Ten", "All�k", "Pembe"),
                new Urun("L'Oreal Paris", "Ten", "All�k", "K�rm�z�"),
                new Urun("Flormar", "Ten", "All�k", "Turuncu"),
                new Urun("Maybelline", "Dudak", "Ruj", "K�rm�z�"),
                new Urun("Golden Rose", "Dudak", "Ruj", "Pembe"),
                new Urun("Flormar", "Dudak", "Ruj", "Mor"),
                new Urun("Wet'n Wild", "Dudak", "Dudak Parlat�c�s�", "Pembe"),
                new Urun("Maybelline", "Dudak", "Dudak Parlat�c�s�", "Turuncu"),
                new Urun("L'Oreal Paris", "Dudak", "Dudak Parlat�c�s�", "K�rm�z�"),
                new Urun("Golden Rose", "Dudak", "Dudak Kalemi", "K�rm�z�"),
                new Urun("Flormar", "Dudak", "Dudak Kalemi", "Pembe"),
                new Urun("Wet'n Wild", "Dudak", "Dudak Kalemi", "Kahve"),
                new Urun("Maybelline", "G�z", "Maskara", "Siyah"),
                new Urun("L'Oreal Paris", "G�z", "G�z Kalemi", "Kahverengi"),
                new Urun("Golden Rose", "G�z", "Eyeliner", "Mavi"),
                new Urun("Wet'n Wild", "G�z", "Maskara", "Beyaz"),
                new Urun("Flormar", "T�rnak", "Oje", "K�rm�z�"),
                new Urun("L'Oreal Paris", "T�rnak", "Aseton", "Pembe"),
                new Urun("Wet'n Wild", "T�rnak", "Bak�m �r�nleri", "Beyaz"),
                new Urun("Maybelline", "T�rnak", "Oje", "Siyah")
            };
            urunlerLbox.Items.Clear(); // �nce listeyi temizle

            foreach (Urun urun in urunList)
            {
                if ((urun.GetMarka() == "Maybelline" && maybellineCbox.Checked) ||
                    (urun.GetMarka() == "L'Oreal Paris" && lorealCbox.Checked) ||
                    (urun.GetMarka() == "Golden Rose" && goldenCbox.Checked) ||
                    (urun.GetMarka() == "Flormar" && flormarCbox.Checked) ||
                    (urun.GetMarka() == "Wet'n Wild" && wetCbox.Checked) ||
                    (urun.GetKategori() == "Ten" && tenCbox.Checked) ||
                    (urun.GetKategori() == "G�z" && gozCbox.Checked) ||
                    (urun.GetKategori() == "Dudak" && dudakCbox.Checked) ||
                    (urun.GetKategori() == "T�rnak" && tirnakCbox.Checked) ||
                    (urun.GetAltKategori() == "Fond�ten" && fondotenCbox.Checked) ||
                    (urun.GetAltKategori() == "Kapat�c�" && kapaticiCbox.Checked) ||
                    (urun.GetAltKategori() == "All�k" && allikCbox.Checked) ||
                    (urun.GetAltKategori() == "Far" && farCbox.Checked) ||
                    (urun.GetAltKategori() == "Eyeliner" && eyelinerCbox.Checked) ||
                    (urun.GetAltKategori() == "Maskara" && maskaraCbox.Checked) ||
                    (urun.GetAltKategori() == "Dudak Parlat�c�s�" && dParlaCbox.Checked) ||
                    (urun.GetAltKategori() == "Dudak Kalemi" && dKalemCbox.Checked) ||
                    (urun.GetAltKategori() == "Ruj" && rujCbox.Checked) ||
                    (urun.GetAltKategori() == "Bak�m �r�nleri" && bakimCbox.Checked) ||
                    (urun.GetAltKategori() == "Aseton" && asetonCbox.Checked) ||
                    (urun.GetAltKategori() == "Oje" && ojeCbox.Checked))
                {
                    urunlerLbox.Items.Add(urun); // sadece i�aretli �zelliklere sahip �r�nleri ekle
                }
            }
        }


        private void UrunleriEkle()
        {
            /*
            Urun urun1 = new Urun("Maybelline", "Ten", "Fond�ten", "A��k");
            Urun urun2 = new Urun("Golden Rose", "Ten", "Fond�ten", "Orta");
            Urun urun3 = new Urun("L'Oreal Paris", "Ten", "Fond�ten", "Koyu");
            Urun urun4 = new Urun("Maybelline", "Ten", "Kapat�c�", "A��k");
            Urun urun5 = new Urun("Wet'n Wild", "Ten", "Kapat�c�", "Orta");
            Urun urun6 = new Urun("Flormar", "Ten", "Kapat�c�", "Koyu");
            Urun urun7 = new Urun("Golden Rose", "Ten", "All�k", "Pembe");
            Urun urun8 = new Urun("L'Oreal Paris", "Ten", "All�k", "K�rm�z�");
            Urun urun9 = new Urun("Flormar", "Ten", "All�k", "Turuncu");
            Urun urun10 = new Urun("Maybelline", "Dudak", "Ruj", "K�rm�z�");
            Urun urun11 = new Urun("Golden Rose", "Dudak", "Ruj", "Pembe");
            Urun urun12 = new Urun("Flormar", "Dudak", "Ruj", "Mor");
            Urun urun13 = new Urun("Wet'n Wild", "Dudak", "Dudak Parlat�c�s�", "Pembe");
            Urun urun14 = new Urun("Maybelline", "Dudak", "Dudak Parlat�c�s�", "Turuncu");
            Urun urun15 = new Urun("L'Oreal Paris", "Dudak", "Dudak Parlat�c�s�", "K�rm�z�");
            Urun urun16 = new Urun("Golden Rose", "Dudak", "Dudak Kalemi", "K�rm�z�");
            Urun urun17 = new Urun("Flormar", "Dudak", "Dudak Kalemi", "Pembe");
            Urun urun18 = new Urun("Wet'n Wild", "Dudak", "Dudak Kalemi", "Kahve");
            Urun urun19 = new Urun("Maybelline", "G�z", "Maskara", "Siyah");
            Urun urun20 = new Urun("L'Oreal Paris", "G�z", "G�z Kalemi", "Kahverengi");
            Urun urun21 = new Urun("Golden Rose", "G�z", "Eyeliner", "Mavi");
            Urun urun22 = new Urun("Wet'n Wild", "G�z", "Maskara", "Beyaz");
            Urun urun23 = new Urun("Flormar", "T�rnak", "Oje", "K�rm�z�");
            Urun urun24 = new Urun("L'Oreal Paris", "T�rnak", "Aseton", "Pembe");
            Urun urun25 = new Urun("Wet'n Wild", "T�rnak", "Bak�m �r�nleri", "Beyaz");
            Urun urun26 = new Urun("Maybelline", "T�rnak", "Oje", "Siyah");
            */
            List<Urun> urunList = new List<Urun>()
            {
                new Urun("Maybelline", "Ten", "Fond�ten", "A��k"),
                new Urun("Golden Rose", "Ten", "Fond�ten", "Orta"),
                new Urun("L'Oreal Paris", "Ten", "Fond�ten", "Koyu"),
                new Urun("Maybelline", "Ten", "Kapat�c�", "A��k"),
                new Urun("Wet'n Wild", "Ten", "Kapat�c�", "Orta"),
                new Urun("Flormar", "Ten", "Kapat�c�", "Koyu"),
                new Urun("Golden Rose", "Ten", "All�k", "Pembe"),
                new Urun("L'Oreal Paris", "Ten", "All�k", "K�rm�z�"),
                new Urun("Flormar", "Ten", "All�k", "Turuncu"),
                new Urun("Maybelline", "Dudak", "Ruj", "K�rm�z�"),
                new Urun("Golden Rose", "Dudak", "Ruj", "Pembe"),
                new Urun("Flormar", "Dudak", "Ruj", "Mor"),
                new Urun("Wet'n Wild", "Dudak", "Dudak Parlat�c�s�", "Pembe"),
                new Urun("Maybelline", "Dudak", "Dudak Parlat�c�s�", "Turuncu"),
                new Urun("L'Oreal Paris", "Dudak", "Dudak Parlat�c�s�", "K�rm�z�"),
                new Urun("Golden Rose", "Dudak", "Dudak Kalemi", "K�rm�z�"),
                new Urun("Flormar", "Dudak", "Dudak Kalemi", "Pembe"),
                new Urun("Wet'n Wild", "Dudak", "Dudak Kalemi", "Kahve"),
                new Urun("Maybelline", "G�z", "Maskara", "Siyah"),
                new Urun("L'Oreal Paris", "G�z", "G�z Kalemi", "Kahverengi"),
                new Urun("Golden Rose", "G�z", "Eyeliner", "Mavi"),
                new Urun("Wet'n Wild", "G�z", "Maskara", "Beyaz"),
                new Urun("Flormar", "T�rnak", "Oje", "K�rm�z�"),
                new Urun("L'Oreal Paris", "T�rnak", "Aseton", "Pembe"),
                new Urun("Wet'n Wild", "T�rnak", "Bak�m �r�nleri", "Beyaz"),
                new Urun("Maybelline", "T�rnak", "Oje", "Siyah")
            };
        }


    }
}