namespace demo
{
    public partial class hahaha_form_main : Form
    {
        public hahaha_form_main()
        {
            InitializeComponent();

            
        }

        private void hahaha_form_main_Shown(object sender, EventArgs e)
        {

        }

        private void button_thread_pause_enabled_Click(object sender, EventArgs e)
        {
            ha.Thread_Pause_?.Enabled();
        }

        private void button_thread_pause_disabled_Click(object sender, EventArgs e)
        {
            ha.Thread_Pause_?.Disabled();
        }

        private void button_command_add_Click(object sender, EventArgs e)
        {
            ha.Thread_Command_.Add_Command_Test("ttt");
        }

        private void hahaha_form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            ha.Thread_Pause_?.Disabled();

            ha.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ha.Form_Main_Titlebar_.Show();
        }
    }
}
