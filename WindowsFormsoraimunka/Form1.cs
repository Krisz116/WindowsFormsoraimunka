using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsoraimunka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ellenorzes_Click(object sender, EventArgs e)
        {
            if (azonosito.Value == 0 )
            {
                MessageBox.Show("Nem adott azonosított!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (string.IsNullOrEmpty(nev.Text))
            {
                MessageBox.Show("Nem adott meg nevet!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (angol.Checked == false && olasz.Checked == false  && francia.Checked == false && nemet.Checked == false)
            {
              MessageBox.Show("Nem adott meg nyelvet!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              return;
            }
    
            
            if (string.IsNullOrEmpty(szuletesihely.Text))
            {
                MessageBox.Show("Nem adott meg születésihelyet  !", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            
        }
    }
}
