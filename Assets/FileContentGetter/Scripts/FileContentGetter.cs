using UnityEngine;
using System.IO;

namespace FileContentGetter
{
    /// <summary>
    /// 文件内容获取器
    /// </summary>
    public class FileContentGetter : MonoBehaviour
    {
        /// <summary>
        /// 读取文本内容
        /// </summary>
        /// <param name="url">文件路径</param>
        /// <param name="line">要读取的文件行数</param>
        /// <returns></returns>
        public static string GetFileContent(string url, int line)
        {
            string[] tempStringArray = File.ReadAllLines(url);
            if (line > 0)
            {
                return tempStringArray[line - 1];
            }
            else
            {
                return null;
            }
        }
    }
}