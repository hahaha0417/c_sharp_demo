namespace demo
{
    partial class hahaha_form_main_titlebar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_system = new Panel();
            flow_layout_panel_system = new FlowLayoutPanel();
            button_system_version = new Button();
            button_system_about = new Button();
            button_system_close = new Button();
            panel_title.SuspendLayout();
            panel_base.SuspendLayout();
            panel_body.SuspendLayout();
            panel_system.SuspendLayout();
            flow_layout_panel_system.SuspendLayout();
            SuspendLayout();
            // 
            // panel_title
            // 
            panel_title.Size = new Size(687, 65);
            // 
            // panel_base
            // 
            panel_base.Size = new Size(687, 448);
            // 
            // panel_body
            // 
            panel_body.Controls.Add(panel_system);
            panel_body.Size = new Size(687, 383);
            // 
            // panel_title_system
            // 
            panel_title_system.Location = new Point(469, 0);
            // 
            // panel_logo
            // 
            panel_logo.Click += panel_logo_Click_1;
            // 
            // panel_system
            // 
            panel_system.BackColor = Color.Gray;
            panel_system.Controls.Add(flow_layout_panel_system);
            panel_system.Location = new Point(11, 6);
            panel_system.Name = "panel_system";
            panel_system.Size = new Size(197, 209);
            panel_system.TabIndex = 0;
            // 
            // flow_layout_panel_system
            // 
            flow_layout_panel_system.BackColor = Color.Transparent;
            flow_layout_panel_system.Controls.Add(button_system_version);
            flow_layout_panel_system.Controls.Add(button_system_about);
            flow_layout_panel_system.Controls.Add(button_system_close);
            flow_layout_panel_system.Dock = DockStyle.Fill;
            flow_layout_panel_system.Location = new Point(0, 0);
            flow_layout_panel_system.Name = "flow_layout_panel_system";
            flow_layout_panel_system.Size = new Size(197, 209);
            flow_layout_panel_system.TabIndex = 0;
            // 
            // button_system_version
            // 
            button_system_version.BackColor = Color.FromArgb(30, 30, 30);
            button_system_version.FlatAppearance.BorderSize = 0;
            button_system_version.FlatStyle = FlatStyle.Flat;
            button_system_version.ForeColor = Color.White;
            button_system_version.Location = new Point(3, 3);
            button_system_version.Name = "button_system_version";
            button_system_version.Size = new Size(187, 62);
            button_system_version.TabIndex = 0;
            button_system_version.Text = "版本";
            button_system_version.UseVisualStyleBackColor = false;
            button_system_version.Click += button_system_version_Click;
            // 
            // button_system_about
            // 
            button_system_about.BackColor = Color.FromArgb(30, 30, 30);
            button_system_about.FlatAppearance.BorderSize = 0;
            button_system_about.FlatStyle = FlatStyle.Flat;
            button_system_about.ForeColor = Color.White;
            button_system_about.Location = new Point(3, 71);
            button_system_about.Name = "button_system_about";
            button_system_about.Size = new Size(187, 62);
            button_system_about.TabIndex = 1;
            button_system_about.Text = "關於";
            button_system_about.UseVisualStyleBackColor = false;
            button_system_about.Click += button_system_about_Click;
            // 
            // button_system_close
            // 
            button_system_close.BackColor = Color.FromArgb(30, 30, 30);
            button_system_close.FlatAppearance.BorderSize = 0;
            button_system_close.FlatStyle = FlatStyle.Flat;
            button_system_close.ForeColor = Color.White;
            button_system_close.Location = new Point(3, 139);
            button_system_close.Name = "button_system_close";
            button_system_close.Size = new Size(187, 62);
            button_system_close.TabIndex = 2;
            button_system_close.Text = "關閉";
            button_system_close.UseVisualStyleBackColor = false;
            button_system_close.Click += button_system_close_Click;
            // 
            // hahaha_form_main_titlebar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(707, 468);
            Name = "hahaha_form_main_titlebar";
            panel_title.ResumeLayout(false);
            panel_base.ResumeLayout(false);
            panel_body.ResumeLayout(false);
            panel_system.ResumeLayout(false);
            flow_layout_panel_system.ResumeLayout(false);
            ResumeLayout(false);




        }

        #endregion


        private Panel panel_system;
        private FlowLayoutPanel flow_layout_panel_system;
        private Button button_system_version;
        private Button button_system_about;
        private Button button_system_close;
    }
}