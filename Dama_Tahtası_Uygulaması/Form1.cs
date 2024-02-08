using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dama_Tahtası_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            for(int i = 0; i < 64; i++)
            {
                Button buton = new Button();   // button clası tanımlandı
                buton.Width = 50;              // buton genişliği ayarlandı
                buton.Height = 50;             // buton yüksekliği ayarlandı

                this.Controls.Add(buton);      // Buton eklendi 

            }    // Burada for döngüsü kullanarak üst üste 64 tae buton oluşturduk. Ve burada bir nesneye erişmek sıkıntı.
            */

            /*
            Button buton = new Button();   // button clası tanımlandı
            buton.Width = 50;              // buton genişliği ayarlandı
            buton.Height = 50;             // buton yüksekliği ayarlandı

            this.Controls.Add(buton);      // Buton eklendi 
            */

            Button[,] butonlar = new Button[8, 8];    // buton arrayı oluşturuldu
            int top = 0;   // butonun yükseklik konumu için tanımladık
            int left = 0;  // butonun yataydaki konumu için tanımladık
            for (int i = 0; i <= butonlar.GetUpperBound(0); i++)
            {
                
                for (int j = 0; j <= butonlar.GetUpperBound(1); j++)
                {
                    butonlar[i, j] = new Button();
                    butonlar[i, j].Width = 50;
                    butonlar[i, j].Height = 50;
                    butonlar[i,j].Left = left;
                    butonlar[i,j].Top = top;
                    left += 50;
                    if((i + j) % 2 == 0) 
                    {
                        butonlar[i,j].BackColor = Color.Black;
                    }
                    else
                    {
                        butonlar[i,j].BackColor= Color.White;
                    }
                    this.Controls.Add(butonlar[i, j]);
                }
                top += 50;
                left = 0;
            }
        }
    }
}
