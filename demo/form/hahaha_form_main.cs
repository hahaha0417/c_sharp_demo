namespace demo
{
    public partial class hahaha_form_main : Form
    {
        public hahaha_form_main()
        {
            InitializeComponent();

            ha.Initial(this);

            ha.Thread_Create();
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
    }
}
