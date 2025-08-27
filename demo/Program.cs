namespace demo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            info.Initial();
            hahaha_form_main form_main_ = new hahaha_form_main();
            ha.Initial(form_main_);
            

            Application.Run(new hahaha_content_main());


            ha.Thread_Create();
            Application.Run(form_main_);
        }
    }

    public class hahaha_content_main : ApplicationContext
    {
        public hahaha_content_main()
        {
            ha.Form_Cover_.FormBorderStyle = FormBorderStyle.None;
            ha.Form_Cover_.StartPosition = FormStartPosition.CenterScreen;


            ha.Form_Cover_.label_name.Text = info.Name;
            ha.Form_Cover_.label_status.Text = "";
            ha.Form_Cover_.Show();
            
            // ��l�Ʈ��O�@���S���Y
            new Thread(() =>
            {
                ha.Form_Cover_.BeginInvoke(() => {
                    ha.Form_Cover_.label_status.Text = "���J...";
                });
                Thread.Sleep(1000);
                ha.Form_Cover_.BeginInvoke(() => {
                    ha.Form_Cover_.label_status.Text = "Ū���Ѽ�...";
                });
                Thread.Sleep(1000);
                ha.Form_Cover_.BeginInvoke(() => {
                    ha.Form_Cover_.label_status.Text = "��l��...";
                });
                Thread.Sleep(1000);
                ExitThread();
            }).Start();

        }
    }
}