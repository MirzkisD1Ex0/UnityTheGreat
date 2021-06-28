using UnityEngine;
using System.Runtime.InteropServices;

namespace KeyboardSimulator
{
    /// <summary>
    /// 模拟物理按键
    /// </summary>
    public class KeyboardSimulator : MonoBehaviour
    {
        [DllImport("user32.dll", EntryPoint = "keybd_event")]
        public static extern void keybd_event(
            byte bvk, // 虚拟键值，ASCII
            byte bScan, // 0
            int dwFlags, // 0按下，1按住，2释放
            int dwExtraInfo // 0
            );

        private void Start()
        {
            // keybd_event(17, 0, 0, 0);
            keybd_event(65, 0, 0, 0);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("模拟物理按键A成功");
            }
        }
    }
}