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

            urunlerLbox.SelectedIndexChanged += UrunlerLbox_SelectedIndexChanged;
        }

        private void UrunlerLbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (urunlerLbox.SelectedIndex != -1)
            {
                Urun selectedUrun = (Urun)urunlerLbox.SelectedItem;

                urunList.Add(selectedUrun);

                urunlerLbox.ClearSelected();
            }
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
                new TenUrun("Maybelline", "Fond�ten", "A��k", 300),
                new TenUrun("Maybelline", "Fond�ten", "Orta", 300),
                new TenUrun("Maybelline", "Kapat�c�", "Orta", 290),
                new TenUrun("Maybelline", "All�k", "K�rm�z�", 200),
                new TenUrun("L'Oreal Paris", "Fond�ten", "Orta", 350),
                new TenUrun("L'Oreal Paris", "Kapat�c�", "A��k", 320),
                new TenUrun("L'Oreal Paris", "Kapat�c�", "Koyu", 320),
                new TenUrun("L'Oreal Paris", "All�k", "Pembe", 200),
                new TenUrun("Flormar", "Fond�ten", "A��k", 250),
                new TenUrun("Flormar", "Kapat�c�", "Koyu", 250),
                new TenUrun("Flormar", "All�k", "Pembe", 170),
                new TenUrun("Flormar", "All�k", "Turuncu", 170),
                new TenUrun("Golden Rose", "Fond�ten", "Orta", 180),
                new TenUrun("Golden Rose", "Fond�ten", "Koyu", 180),
                new TenUrun("Golden Rose", "Kapat�c�", "A��k", 160),
                new TenUrun("Golden Rose", "All�k", "K�rm�z�", 150),
                new TenUrun("Wet'n Wild", "Fond�ten", "A��k", 250),
                new TenUrun("Wet'n Wild", "Fond�ten", "Koyu", 250),
                new TenUrun("Wet'n Wild", "Kapat�c�", "Orta", 200),
                new TenUrun("Wet'n Wild", "All�k", "Turuncu", 130),
                new DudakUrun("Maybelline", "Ruj", "K�rm�z�", 320),
                new DudakUrun("Maybelline", "Dudak Kalemi ", "Pembe", 240),
                new DudakUrun("Maybelline", "Dudak Parlat�c�s�", "Beyaz", 200),
                new DudakUrun("L'Oreal Paris", "Ruj", "Kahve", 300),
                new DudakUrun("L'Oreal Paris", "Dudak Kalemi", "Mor", 210),
                new DudakUrun("L'Oreal Paris", "Dudak Parlat�c�s�", "�eftali", 180),
                new DudakUrun("Flormar", "Ruj", "Pembe", 190),
                new DudakUrun("Flormar", "Dudak Kalemi", "K�rm�z�", 120),
                new DudakUrun("Flormar", "Dudak Parlat�c�s�", "Beyaz", 110),
                new DudakUrun("Golden Rose", "Ruj", "�eftali", 170),
                new DudakUrun("Golden Rose", "Dudak Kalemi", "Kahve", 45),
                new DudakUrun("Golden Rose", "Dudak Parlat�c�s�", "K�rm�z�", 140),
                new DudakUrun("Wet'n Wild", "Ruj", "Mor", 210),
                new DudakUrun("Wet'n Wild", "Dudak Kalemi", "�eftali", 180),
                new DudakUrun("Wet'n Wild", "Dudak Parlat�c�s�", "Pembe", 140),
                new GozUrun("Maybelline", "Maskara", "Siyah", 330),
                new GozUrun("Maybelline", "Eyeliner", "Kahverengi", 150),
                new GozUrun("Maybelline", "Far Paleti", "So�uk Tonlar", 240),
                new GozUrun("L'Oreal Paris", "Maskara", "Kahverengi", 250),
                new GozUrun("L'Oreal Paris", "Eyeliner", "Mavi", 130),
                new GozUrun("L'Oreal Paris", "Far Paleti", "S�cak Tonlar", 250),
                new GozUrun("Flormar", "Maskara", "Mavi", 270),
                new GozUrun("Flormar", "Eyeliner", "Siyah", 140),
                new GozUrun("Flormar", "Far Paleti", "Renkli", 200),
                new GozUrun("Golden Rose", "Maskara", "Siyah", 85),
                new GozUrun("Golden Rose", "Eyeliner", "Mavi", 50),
                new GozUrun("Golden Rose", "Far Paleti", "S�cak Tonlar", 100),
                new GozUrun("Wet'n Wild", "Maskara", "Beyaz", 380),
                new GozUrun("Wet'n Wild", "Eyeliner", "Siyah", 380),
                new GozUrun("Wet'n Wild", "Far Paleti", "So�uk Tonlar", 380),
                new TirnakUrun("Flormar", "Oje", "K�rm�z�", 50),
                new TirnakUrun("Flormar", "Oje", "Mavi", 50),
                new TirnakUrun("Flormar", "Aseton", "Pembe", 80),
                new TirnakUrun("Golden Rose", "Oje", "Ye�il", 45),
                new TirnakUrun("Golden Rose", "Oje", "K�rm�z�", 45),
                new TirnakUrun("Golden Rose", "Aseton", "Turuncu", 70),
                new TirnakUrun("Wet'n Wild", "Oje", "Bordo", 45),
                new TirnakUrun("Wet'n Wild", "Aseton", "Ye�il", 50),
                new TirnakUrun("Wet'n Wild", "Bak�m �r�nleri", "Beyaz", 120),
                new TirnakUrun("Wet'n Wild", "Bak�m �r�nleri", "Siyah", 120)
            };
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void Filtrele()
        {
            urunlerLbox.Items.Clear();

            foreach (var urun in urunList)
            {
                if (IsCategorySelected(urun) || IsSubcategorySelected(urun) || IsBrandcategorySelected(urun))
                {
                    urunlerLbox.Items.Add(urun);
                }
            }
        }

        private bool IsCategorySelected(Urun urun)
        {
            if (urun is TenUrun && tenCbox.Checked)
            {
                return true;
            }
            else if (urun is GozUrun && gozCbox.Checked)
            {
                return true;
            }
            else if (urun is DudakUrun && dudakCbox.Checked)
            {
                return true;
            }
            else if (urun is TirnakUrun && tirnakCbox.Checked)
            {
                return true;
            }

            return false;
        }

        private bool IsSubcategorySelected(Urun urun)
        {
            if (urun is TenUrun tenUrun)
            {
                if (fondotenCbox.Checked && tenUrun.altKategori == "Fond�ten")
                {
                    return true;
                }
                else if (kapaticiCbox.Checked && tenUrun.altKategori == "Kapat�c�")
                {
                    return true;
                }
                else if (allikCbox.Checked && tenUrun.altKategori == "All�k")
                {
                    return true;
                }
            }
            else if (urun is GozUrun gozUrun)
            {
                if (maskaraCbox.Checked && gozUrun.altKategori == "Maskara")
                {
                    return true;
                }
                else if (eyelinerCbox.Checked && gozUrun.altKategori == "Eyeliner")
                {
                    return true;
                }
                else if (farCbox.Checked && gozUrun.altKategori == "Far Paleti")
                {
                    return true;
                }
            }
            else if (urun is DudakUrun dudakUrun)
            {
                if (rujCbox.Checked && dudakUrun.altKategori == "Ruj")
                {
                    return true;
                }
                else if (dKalemCbox.Checked && dudakUrun.altKategori == "Dudak Kalemi")
                {
                    return true;
                }
                else if (dParlaCbox.Checked && dudakUrun.altKategori == "Dudak Parlat�c�s�")
                {
                    return true;
                }
            }
            else if (urun is TirnakUrun tirnakUrun)
            {
                if (ojeCbox.Checked && tirnakUrun.altKategori == "Oje")
                {
                    return true;
                }
                else if (asetonCbox.Checked && tirnakUrun.altKategori == "Aseton")
                {
                    return true;
                }
                else if (bakimCbox.Checked && tirnakUrun.altKategori == "Bak�m �r�nleri")
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsBrandcategorySelected(Urun urun)
        {
            if (urun is TenUrun tenUrun)
            {
                if (maybellineCbox.Checked && tenUrun.marka == "Maybelline")
                {
                    return true;
                }
                else if (lorealCbox.Checked && tenUrun.marka == "L'Oreal Paris")
                {
                    return true;
                }
                else if (flormarCbox.Checked && tenUrun.marka == "Flormar")
                {
                    return true;
                }
                else if (goldenCbox.Checked && tenUrun.marka == "Golden Rose")
                {
                    return true;
                }
                else if (wetCbox.Checked && tenUrun.marka == "Wet'n Wild")
                {
                    return true;
                }
            }
            else if (urun is GozUrun gozUrun)
            {
                if (maybellineCbox.Checked && gozUrun.marka == "Maybelline")
                {
                    return true;
                }
                else if (lorealCbox.Checked && gozUrun.marka == "L'Oreal Paris")
                {
                    return true;
                }
                else if (flormarCbox.Checked && gozUrun.marka == "Flormar")
                {
                    return true;
                }
                else if (goldenCbox.Checked && gozUrun.marka == "Golden Rose")
                {
                    return true;
                }
                else if (wetCbox.Checked && gozUrun.marka == "Wet'n Wild")
                {
                    return true;
                }
            }
            else if (urun is DudakUrun dudakUrun)
            {
                if (maybellineCbox.Checked && dudakUrun.marka == "Maybelline")
                {
                    return true;
                }
                else if (lorealCbox.Checked && dudakUrun.marka == "L'Oreal Paris")
                {
                    return true;
                }
                else if (flormarCbox.Checked && dudakUrun.marka == "Flormar")
                {
                    return true;
                }
                else if (goldenCbox.Checked && dudakUrun.marka == "Golden Rose")
                {
                    return true;
                }
                else if (wetCbox.Checked && dudakUrun.marka == "Wet'n Wild")
                {
                    return true;
                }
            }
            else if (urun is TirnakUrun tirnakUrun)
            {
                if (maybellineCbox.Checked && tirnakUrun.marka == "Maybelline")
                {
                    return true;
                }
                else if (lorealCbox.Checked && tirnakUrun.marka == "L'Oreal Paris")
                {
                    return true;
                }
                else if (flormarCbox.Checked && tirnakUrun.marka == "Flormar")
                {
                    return true;
                }
                else if (goldenCbox.Checked && tirnakUrun.marka == "Golden Rose")
                {
                    return true;
                }
                else if (wetCbox.Checked && tirnakUrun.marka == "Wet'n Wild")
                {
                    return true;
                }
            }

            return false;
        }

        private void urunlerLbox_MouseClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = urunlerLbox.IndexFromPoint(e.Location);

            if (selectedIndex != ListBox.NoMatches)
            {
                Urun selectedUrun = (Urun)urunlerLbox.Items[selectedIndex];

                sepetimLbox.Items.Add(selectedUrun);
            }
        }

        private void cikarmaButton_Click(object sender, EventArgs e)
        {
            if (sepetimLbox.SelectedIndex != -1)
            {
                Urun selectedUrun = (Urun)sepetimLbox.SelectedItem;

                sepetimLbox.Items.Remove(selectedUrun);
            }
        }

        private void hesaplaButton_Click(object sender, EventArgs e)
        {
            decimal toplamFiyat = ToplamFiyatHesapla();
            toplamTbox.Text = toplamFiyat.ToString("N");
        }

        private decimal ToplamFiyatHesapla()
        {
            decimal toplamFiyat = 0;

            foreach (var item in sepetimLbox.Items)
            {
                if (item is Urun urun)
                {
                    toplamFiyat += urun.fiyat;
                }
            }

            return toplamFiyat;
        }
    }
}
