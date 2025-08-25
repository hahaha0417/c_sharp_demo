using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class hahaha_form_main_titlebar : hahahalib.ui.hahaha_form_base_titlebar
    {
        public hahaha_form_main_titlebar()
        {
            InitializeComponent();

           
        
        }

        private void hahaha_form_main_titlebar_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;   // 取消關閉
            Hide();       // 改成隱藏
        }

        private void panelToolStripButton_Click(object sender, EventArgs e)
        {
             
        }
    }
}
