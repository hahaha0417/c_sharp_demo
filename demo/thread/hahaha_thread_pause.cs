using System;
using System.Threading;

namespace demo
{
    /// <summary>
    /// 可被繼承的執行緒暫停控制類
    /// - Create() 建立執行緒與事件
    /// - Enabled() 觸發執行緒執行 Handle()
    /// - Wait() 等待 Handle() 完成
    /// - Close() 關閉執行緒與資源
    /// - Terminate() 強制終止（危險，盡量避免）
    /// </summary>
    public class hahaha_thread_pause : hahahalib.hahaha_thread_pause
    {
        public bool is_hahaha_thread_pause_close = true;

        public hahaha_thread_pause()
        {
            Reset();
        }

       


        /// <summary>
        /// 啟動一次 Handle()
        /// </summary>
        public override void Enabled()
        {
            if (is_hahaha_thread_pause_close)
            {
                is_hahaha_thread_pause_close = false;
                Event_Run_?.Set();
            }
            
        }

        /// <summary>
        /// Disabled
        /// </summary>
        public override void Disabled()
        {
            if (!is_hahaha_thread_pause_close)
            {
                
                is_hahaha_thread_pause_close = true;
               
            }
        }

       

        /// <summary>
        /// 子類別覆寫，實際處理工作
        /// </summary>
        public override void Handle()
        {
            while (!is_hahaha_thread_pause_close)
            { 
                ha.Form_Main_?.BeginInvoke(() => {
                    MessageBox.Show("test");
                
                });


                Thread.Sleep(2000);
            }
        }
    }
}
