using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class frmSatisHareketleri : Form
    {
        int IntParseBag = 0; long LongParseBag = 0; double DoubleParseBag = 0;
        DAL budak; Fonksiyonlar Tornavida;
        public int uye_id;
        string yetki_duzeyi;
        public frmSatisHareketleri(int _uye_id, string _yetki_duzeyi, string _islem)
        {
            InitializeComponent();
            uye_id = _uye_id;
            yetki_duzeyi = _yetki_duzeyi;
            //islem = _islem;
        }
    }
}
