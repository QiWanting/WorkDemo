using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;

namespace CPUMonitor
{
    public partial class Form1 : Form
    {
        VividPicture vividPicture;
        public Form1()
        {
            InitializeComponent();
            vividPicture = new VividPicture(this.notifyIcon1,
                @"D:\own\Code\WorkDemo\WorkDemo\CPUMonitor\VividResource\Level0\Level0_1.ico",
                @"D:\own\Code\WorkDemo\WorkDemo\CPUMonitor\VividResource\Level0\Level0_2.ico",
                @"D:\own\Code\WorkDemo\WorkDemo\CPUMonitor\VividResource\Level0\Level0_3.ico",
                null, null, null, null, null, null
                );
            GetCpuUse();
        }

        public async void GetCpuUse()
        {
            PerformanceCounter cpuCounter;
            PerformanceCounter ramCounter;

            //cpuCounter = new PerformanceCounter();
            //cpuCounter.CategoryName = "Processor";
            //cpuCounter.CounterName = "% Processor Time";
            //cpuCounter.InstanceName = "_Total";
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");



            //Console.WriteLine("电脑CPU使用率：" + cpuCounter.NextValue() + "%");
            //Console.WriteLine("电脑可使用内存：" + ramCounter.NextValue() + "MB");
            //Console.WriteLine();

            System.Drawing.Icon icon1 = new System.Drawing.Icon(@"D:\own\Code\WorkDemo\WorkDemo\CPUMonitor\VividResource\Level0\Level0_1.ico");
            System.Drawing.Icon icon2 = new System.Drawing.Icon(@"D:\own\Code\WorkDemo\WorkDemo\CPUMonitor\VividResource\Level0\Level0_2.ico");
            System.Drawing.Icon icon3 = new System.Drawing.Icon(@"D:\own\Code\WorkDemo\WorkDemo\CPUMonitor\VividResource\Level0\Level0_3.ico");

            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                //Console.WriteLine("电脑CPU使用率：" + cpuCounter.NextValue() + " %");
                //Console.WriteLine("电脑可使用内存：" + ramCounter.NextValue() + "MB");
                //Console.WriteLine();

                await vividPicture.VividPictureLevel0();

                if ((int)cpuCounter.NextValue() > 80)
                {
                    System.Threading.Thread.Sleep(1000 * 60);
                }
            }
        }

        public void BouncingIcon(CPULevelType cpulevel)
        {
            switch (cpulevel)
            {
                //各个图片动作循环
                case CPULevelType.Level0:; break;
                case CPULevelType.Level50:; break;
                case CPULevelType.Level100:; break;
                default: break;
            }
        }
        /// <summary>
        /// 获取屏幕Dpi重新计算显示宽度和高度
        /// </summary>
        public void GetScreenSize()
        {
            // 调用GetSystemDPI方法并打印DPI值
            uint systemDPI = DPIHelper.GetSystemDPI();
            Console.WriteLine("System DPI: " + systemDPI);

            double x = SystemParameters.WorkArea.Width;//得到屏幕工作区域宽度
            double y = SystemParameters.WorkArea.Height;//得到屏幕工作区域高度
            double x1 = SystemParameters.PrimaryScreenWidth;//得到屏幕整体宽度
            double y1 = SystemParameters.PrimaryScreenHeight;//得到屏幕整体高度

            double width = SystemParameters.PrimaryScreenWidth;
            double height = SystemParameters.PrimaryScreenHeight;
            this.Width = (int)(width * (0.7));
            this.Height = (int)(height * (0.7));
        }
    }
    public class DPIHelper
    {
        // 导入GetDpiForSystem函数
        [DllImport("user32.dll")]
        private static extern uint GetDpiForSystem();

        // 定义一个方法来获取系统DPI
        public static uint GetSystemDPI()
        {
            // 调用GetDpiForSystem函数并返回DPI值
            uint dpi = GetDpiForSystem();
            return dpi;
        }
    }


}
