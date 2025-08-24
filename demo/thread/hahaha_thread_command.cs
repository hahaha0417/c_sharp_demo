using System;
using System.Collections.Generic;
using System.Threading;

namespace demo
{

    public class hahaha_thread_command_command
    {
        public static string TEST = "test";
    }



    /// <summary>
    /// C# 版：hahaha_thread_command
    /// - Create(): 建立背景執行緒與事件
    /// - AddCommand(): 丟入一個命令並喚醒執行緒
    /// - Wait(): 等到當前批次命令處理完成（或被要求退出）
    /// - Close(): 通知退出並釋放資源
    /// - Terminate(): 安全版的通知退出（不強殺）
    /// - Handle(): 覆寫以處理單一命令
    /// </summary>
    public class hahaha_thread_command : hahahalib.hahaha_thread_command
    {
        

        // === 建構/重設 ===
        public hahaha_thread_command()
        {
            Reset();
        }

       

       

        // === 丟入命令 ===
        public virtual int Add_Command_Test(string text)
        {
            if (Event_Run_ == null) return -1;

            hahahalib.hahaha_thread_command_command cmd_ = new hahahalib.hahaha_thread_command_command();
            cmd_.Code_ = hahaha_thread_command_command.TEST;
            cmd_.Parameter_ = text;

            lock (Lock_)
            {
                Queue_.Enqueue(cmd_);
                // 有命令就喚醒
                Event_Run_.Set();
            }
            return 0;
        }

        /// <summary>
        /// 若你想複寫「命令建立流程」可覆寫本方法；預設改走 AddCommand。
        /// </summary>
        public virtual int On_Command_Test(string text)
        {
            ha.Form_Main_?.BeginInvoke(() => {
                MessageBox.Show(text);

            });

            return 0;
        }



        public override int Handle(hahahalib.hahaha_thread_command_command cmd)
        {
            if (cmd.Code_ == hahaha_thread_command_command.TEST)
            {
                string? text = cmd.Parameter_ as string;
                On_Command_Test(text);
            }
            return 0;
        }

      
    }
}
