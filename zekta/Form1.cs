using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zekta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ZekatMiktari;
            double ZekatAltinGr;
            ZekatAltinGr=Convert.ToDouble(textBox1.Text)/975;
            if (ZekatAltinGr >= 80.18)
            {
                ZekatMiktari = (ZekatAltinGr / 40) * 975;
               label2.Text="Zekat miktarı" + ZekatMiktari.ToString();
            }
            else
            { label2.Text="Zekat vermek icin paranız yetersiz";
            }
        }
      
      
       
          

    }

}
