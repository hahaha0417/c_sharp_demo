using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace demo
{


    public partial class hahaha_form_main_titlebar : hahahalib.ui.hahaha_form_base_titlebar
    {
        // 建一次即可
        public ToolStripDropDown? Dropdown_System_ = null;
        public hahaha_form_main_titlebar()
        {
            InitializeComponent();

            button_system_version.BackColor = Color_Button_Base_;
            button_system_version.FlatAppearance.MouseOverBackColor = Color_Button_Move_;
            button_system_version.FlatAppearance.MouseDownBackColor = Color_Button_Down_;
            button_system_version.ForeColor = Color.White;

            button_system_about.BackColor = Color_Button_Base_;
            button_system_about.FlatAppearance.MouseOverBackColor = Color_Button_Move_;
            button_system_about.FlatAppearance.MouseDownBackColor = Color_Button_Down_;
            button_system_about.ForeColor = Color.White;

            button_system_close.BackColor = Color_Button_Base_;
            button_system_close.FlatAppearance.MouseOverBackColor = Color_Button_Move_;
            button_system_close.FlatAppearance.MouseDownBackColor = Color_Button_Down_;
            button_system_close.ForeColor = Color.White;

            panel_system.BackColor = Color_System_;
            // ---------------------------------------- 
            var host = new ToolStripControlHost(panel_system) { Margin = Padding.Empty, Padding = Padding.Empty, AutoSize = false };
            Dropdown_System_ = new ToolStripDropDown { AutoClose = true, Padding = Padding.Empty };
            Dropdown_System_.Items.Add(host);
            panel_system.Parent = null;
            // ---------------------------------------- 
        }

        private void hahaha_form_main_titlebar_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;   // 取消關閉
            Hide();       // 改成隱藏
        }

        private void panelToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void button_system_version_Click(object sender, EventArgs e)
        {
            ha.Form_Version_.label_title.Text = "版本";
            ha.Form_Version_.label_name.Text = info.Name;
            ha.Form_Version_.label_description.Text = info.Description_;
            ha.Form_Version_.label_version.Text = info.Version_;
            ha.Form_Version_.label_company.Text = info.Company_;
            ha.Form_Version_.label_license.Text = info.License_;
            ha.Form_Version_.Show();
        }

        private void button_system_about_Click(object sender, EventArgs e)
        {
            ha.Form_About_.label_title.Text = "關於";
            ha.Form_About_.label_name.Text = info.About_Name_;
            ha.Form_About_.text_content.Lines = info.About_Content_.ToArray();
            ha.Form_About_.Show();
        }

        private void button_system_close_Click(object sender, EventArgs e)
        {
            Hide();       // 改成隱藏
        }

        private void panel_logo_Click_1(object sender, EventArgs e)
        {
            var pt = this.PointToScreen(panel_logo.Location);
            pt.Offset(Form_Border_Width_, panel_logo.Height + Form_Border_Width_); // 顯示在按鈕下方
            Dropdown_System_.Show(pt);               // 點外面會自動關閉
        }
    }
}
