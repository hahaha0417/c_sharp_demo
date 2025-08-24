using System;
using System.Threading;

namespace demo
{
    public static class ha
    {
        public static hahaha_thread_command? Thread_Command_;
        public static hahaha_thread_pause? Thread_Pause_;
        public static hahaha_form_main? Form_Main_;

        public static int Initial(hahaha_form_main form)
        {
            Thread_Command_ = new hahaha_thread_command();
            Thread_Pause_ = new hahaha_thread_pause();

            Form_Main_ = form;

            return 0;
        }

        public static int Thread_Create()
        {
            Thread_Command_.Create();
            Thread_Pause_.Create();

            return 0;
        }


        public static int Close()
        {
            Thread_Command_.Close();
            Thread_Pause_.Close();


            return 0;
        }
    }


}