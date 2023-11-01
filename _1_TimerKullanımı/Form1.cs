using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_TimerKullanımı
{
    public partial class Form1 : Form
    {
        // Timer : Belirli bir süre dahilinde belirli bir iş yaptırmaya yarar.
        // her 10 dakikada bir uyarı ver, her 5 sn de bir kontrol et, her 2 saatte bir veritabanının yedeğini al vs.
        // Interval Özelliği : Timer ın, belirtilen işi ne kadar sürede bir yapacağını belirler. milisaniye cinsinden değer alır.
        // Tick Olayı : Intervalde belirlenen süre her geçtiğinde, Tick olayı otomatik olarak çalışır.
        // NOT : Timer ın çalışmaya başlaması için Start() metodu kullnaılmalıdır. Timer kendi kendine çalışmaya başlamaz.



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int sayac;
        private void tmrZamanlayici_Tick(object sender, EventArgs e)
        {
            sayac++;
            lblSayaç.Text = sayac + "";
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            //tmrZamanlayici.Start(); // timer ın çalışmaya başlamasını sağlar
            tmrZamanlayici.Enabled = true; // böyle de başlatılabilir
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            // tmrZamanlayici.Stop(); // timer ın çalışmasını durdurur.
            tmrZamanlayici.Enabled = false;// böyle de durdurulabilir
        }
    }
}
