using System.Windows.Forms;
using UrunSinif;

namespace ProjeFrontDeneme
{
    public partial class Form1 : Form
    {

        private List<Urun> urunList;
        public Form1()
        {
            InitializeComponent();
            InitializeCheckBoxes();
            InitializeUrunler();
            Filtrele();
        }

        private void InitializeCheckBoxes()
        {
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

        private void InitializeUrunler()
        {
            urunList = new List<Urun>()
            {
                new TenUrun("Maybelline", "Fondöten", "Açýk"),
                new TenUrun("Golden Rose", "Fondöten", "Orta"),
                new TenUrun("L'Oreal Paris", "Fondöten", "Koyu"),
                new TenUrun("Maybelline", "Kapatýcý", "Açýk"),
                new TenUrun("Wet'n Wild", "Kapatýcý", "Orta"),
                new TenUrun("Flormar", "Kapatýcý", "Koyu"),
                new TenUrun("Golden Rose", "Allýk", "Pembe"),
                new TenUrun("L'Oreal Paris", "Allýk", "Kýrmýzý"),
                new TenUrun("Flormar", "Allýk", "Turuncu"),
                new DudakUrun("Maybelline", "Ruj", "Kýrmýzý"),
                new DudakUrun("Golden Rose", "Ruj", "Pembe"),
                new DudakUrun("Flormar", "Ruj", "Mor"),
                new DudakUrun("Wet'n Wild", "Dudak Parlatýcýsý", "Pembe"),
                new DudakUrun("Maybelline", "Dudak Parlatýcýsý", "Turuncu"),
                new DudakUrun("L'Oreal Paris", "Dudak Parlatýcýsý", "Kýrmýzý"),
                new DudakUrun("Golden Rose", "Dudak Kalemi", "Kýrmýzý"),
                new DudakUrun("Flormar", "Dudak Kalemi", "Pembe"),
                new DudakUrun("Wet'n Wild", "Dudak Kalemi", "Kahve"),
                new GozUrun("Maybelline", "Maskara", "Siyah"),
                new GozUrun("L'Oreal Paris", "Göz Kalemi", "Kahverengi"),
                new GozUrun("Golden Rose", "Eyeliner", "Mavi"),
                new GozUrun("Wet'n Wild", "Maskara", "Beyaz"),
                new TirnakUrun("Flormar", "Oje", "Kýrmýzý"),
                new TirnakUrun("L'Oreal Paris", "Aseton", "Pembe"),
                new TirnakUrun("Wet'n Wild", "Bakým Ürünleri", "Beyaz"),
                new TirnakUrun("Maybelline", "Oje", "Siyah")
            };
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Filtrele();
        }
        private void Filtrele()
        {
            urunlerLbox.Items.Clear(); // önce listeyi temizle

        }
        
    }
}

/*private void UrunleriEkle()
        {
            
            Urun urun1 = new Urun("Maybelline", "Ten", "Fondöten", "Açýk");
            Urun urun2 = new Urun("Golden Rose", "Ten", "Fondöten", "Orta");
            Urun urun3 = new Urun("L'Oreal Paris", "Ten", "Fondöten", "Koyu");
            Urun urun4 = new Urun("Maybelline", "Ten", "Kapatýcý", "Açýk");
            Urun urun5 = new Urun("Wet'n Wild", "Ten", "Kapatýcý", "Orta");
            Urun urun6 = new Urun("Flormar", "Ten", "Kapatýcý", "Koyu");
            Urun urun7 = new Urun("Golden Rose", "Ten", "Allýk", "Pembe");
            Urun urun8 = new Urun("L'Oreal Paris", "Ten", "Allýk", "Kýrmýzý");
            Urun urun9 = new Urun("Flormar", "Ten", "Allýk", "Turuncu");
            Urun urun10 = new Urun("Maybelline", "Dudak", "Ruj", "Kýrmýzý");
            Urun urun11 = new Urun("Golden Rose", "Dudak", "Ruj", "Pembe");
            Urun urun12 = new Urun("Flormar", "Dudak", "Ruj", "Mor");
            Urun urun13 = new Urun("Wet'n Wild", "Dudak", "Dudak Parlatýcýsý", "Pembe");
            Urun urun14 = new Urun("Maybelline", "Dudak", "Dudak Parlatýcýsý", "Turuncu");
            Urun urun15 = new Urun("L'Oreal Paris", "Dudak", "Dudak Parlatýcýsý", "Kýrmýzý");
            Urun urun16 = new Urun("Golden Rose", "Dudak", "Dudak Kalemi", "Kýrmýzý");
            Urun urun17 = new Urun("Flormar", "Dudak", "Dudak Kalemi", "Pembe");
            Urun urun18 = new Urun("Wet'n Wild", "Dudak", "Dudak Kalemi", "Kahve");
            Urun urun19 = new Urun("Maybelline", "Göz", "Maskara", "Siyah");
            Urun urun20 = new Urun("L'Oreal Paris", "Göz", "Göz Kalemi", "Kahverengi");
            Urun urun21 = new Urun("Golden Rose", "Göz", "Eyeliner", "Mavi");
            Urun urun22 = new Urun("Wet'n Wild", "Göz", "Maskara", "Beyaz");
            Urun urun23 = new Urun("Flormar", "Týrnak", "Oje", "Kýrmýzý");
            Urun urun24 = new Urun("L'Oreal Paris", "Týrnak", "Aseton", "Pembe");
            Urun urun25 = new Urun("Wet'n Wild", "Týrnak", "Bakým Ürünleri", "Beyaz");
            Urun urun26 = new Urun("Maybelline", "Týrnak", "Oje", "Siyah");
            
        List<Urun> urunList = new List<Urun>()
            {
                new Urun("Maybelline", "Ten", "Fondöten", "Açýk"),
                new Urun("Golden Rose", "Ten", "Fondöten", "Orta"),
                new Urun("L'Oreal Paris", "Ten", "Fondöten", "Koyu"),
                new Urun("Maybelline", "Ten", "Kapatýcý", "Açýk"),
                new Urun("Wet'n Wild", "Ten", "Kapatýcý", "Orta"),
                new Urun("Flormar", "Ten", "Kapatýcý", "Koyu"),
                new Urun("Golden Rose", "Ten", "Allýk", "Pembe"),
                new Urun("L'Oreal Paris", "Ten", "Allýk", "Kýrmýzý"),
                new Urun("Flormar", "Ten", "Allýk", "Turuncu"),
                new Urun("Maybelline", "Dudak", "Ruj", "Kýrmýzý"),
                new Urun("Golden Rose", "Dudak", "Ruj", "Pembe"),
                new Urun("Flormar", "Dudak", "Ruj", "Mor"),
                new Urun("Wet'n Wild", "Dudak", "Dudak Parlatýcýsý", "Pembe"),
                new Urun("Maybelline", "Dudak", "Dudak Parlatýcýsý", "Turuncu"),
                new Urun("L'Oreal Paris", "Dudak", "Dudak Parlatýcýsý", "Kýrmýzý"),
                new Urun("Golden Rose", "Dudak", "Dudak Kalemi", "Kýrmýzý"),
                new Urun("Flormar", "Dudak", "Dudak Kalemi", "Pembe"),
                new Urun("Wet'n Wild", "Dudak", "Dudak Kalemi", "Kahve"),
                new Urun("Maybelline", "Göz", "Maskara", "Siyah"),
                new Urun("L'Oreal Paris", "Göz", "Göz Kalemi", "Kahverengi"),
                new Urun("Golden Rose", "Göz", "Eyeliner", "Mavi"),
                new Urun("Wet'n Wild", "Göz", "Maskara", "Beyaz"),
                new Urun("Flormar", "Týrnak", "Oje", "Kýrmýzý"),
                new Urun("L'Oreal Paris", "Týrnak", "Aseton", "Pembe"),
                new Urun("Wet'n Wild", "Týrnak", "Bakým Ürünleri", "Beyaz"),
                new Urun("Maybelline", "Týrnak", "Oje", "Siyah")
            };
        }
        */