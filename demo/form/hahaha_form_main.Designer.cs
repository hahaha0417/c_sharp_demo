namespace demo
{
    partial class hahaha_form_main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_thread_pause_enabled = new Button();
            button_thread_pause_disabled = new Button();
            button_command_add = new Button();
            SuspendLayout();
            // 
            // button_thread_pause_enabled
            // 
            button_thread_pause_enabled.Location = new Point(63, 29);
            button_thread_pause_enabled.Name = "button_thread_pause_enabled";
            button_thread_pause_enabled.Size = new Size(99, 67);
            button_thread_pause_enabled.TabIndex = 0;
            button_thread_pause_enabled.Text = "Thread Pause Enabled";
            button_thread_pause_enabled.UseVisualStyleBackColor = true;
            button_thread_pause_enabled.Click += button_thread_pause_enabled_Click;
            // 
            // button_thread_pause_disabled
            // 
            button_thread_pause_disabled.Location = new Point(178, 29);
            button_thread_pause_disabled.Name = "button_thread_pause_disabled";
            button_thread_pause_disabled.Size = new Size(99, 67);
            button_thread_pause_disabled.TabIndex = 1;
            button_thread_pause_disabled.Text = "Thread Pause Disabled";
            button_thread_pause_disabled.UseVisualStyleBackColor = true;
            button_thread_pause_disabled.Click += button_thread_pause_disabled_Click;
            // 
            // button_command_add
            // 
            button_command_add.Location = new Point(63, 115);
            button_command_add.Name = "button_command_add";
            button_command_add.Size = new Size(99, 67);
            button_command_add.TabIndex = 2;
            button_command_add.Text = "Thread Command Add";
            button_command_add.UseVisualStyleBackColor = true;
            button_command_add.Click += button_command_add_Click;
            // 
            // hahaha_form_main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_command_add);
            Controls.Add(button_thread_pause_disabled);
            Controls.Add(button_thread_pause_enabled);
            Name = "hahaha_form_main";
            Text = "demo";
            FormClosing += hahaha_form_main_FormClosing;
            Shown += hahaha_form_main_Shown;
            ResumeLayout(false);
        }

        #endregion

        private Button button_thread_pause_enabled;
        private Button button_thread_pause_disabled;
        private Button button_command_add;
    }
}
