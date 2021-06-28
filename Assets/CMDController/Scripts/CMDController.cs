using UnityEngine;
using System.Diagnostics;

namespace CMDController
{
    /// <summary>
    /// 命令行
    /// </summary>
    public class CMDController : MonoBehaviour
    {
        private void Start()
        {
            Process.Start("notepad.exe");
            // Process.Start(@"D:\software\PotPlayer64\PotPlayerMini64.exe");
        }
    }
    // Process.Start ()	启动（或重用）此 Process 组件的 StartInfo 属性指定的进程资源，并将其与该组件关联。
    // Process.Start (ProcessStartInfo)	启动由包含进程启动信息（例如，要启动的进程的文件名）的参数指定的进程资源，并将该资源与新的 Process 组件关联。
    // Process.Start (String)	通过指定文档或应用程序文件的名称来启动进程资源，并将资源与新的 Process 组件关联。
    // Process.Start (String, String)	通过指定应用程序的名称和一组命令行参数来启动一个进程资源，并将该资源与新的 Process 组件相关联。
    // Process.Start (String, String, SecureString, String)	通过指定应用程序的名称、用户名、密码和域来启动一个进程资源，并将该资源与新的 Process 组件关联起来。
    // Process.Start (String, String, String, SecureString, String)	通过指定应用程序的名称和一组命令行参数、用户名、密码和域来启动一个进程资源，并将该资源与新的 Process 组件关联起来。
}