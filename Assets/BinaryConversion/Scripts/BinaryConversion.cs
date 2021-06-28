using UnityEngine;
using System;
using System.Text;

namespace BinaryConversion
{
    /// <summary>
    /// 二进制与字符串之间互相转换
    /// </summary>
    public class BinaryConversion : MonoBehaviour
    {
        private string stringTemplate = "Unity !s P0w3r.";

        private void Start()
        {
            stringTemplate = StringToBinary(stringTemplate);
            Debug.Log(stringTemplate);

            stringTemplate = BinaryToString(stringTemplate);
            Debug.Log(stringTemplate);
        }

        /// <summary>
        /// 字符串转二进制
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string StringToBinary(string str)
        {
            byte[] data = Encoding.Default.GetBytes(str);
            StringBuilder sb = new StringBuilder(data.Length * 8);
            foreach (byte item in data)
            {
                sb.Append(Convert.ToString(item, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 二进制转字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string BinaryToString(string str)
        {
            System.Text.RegularExpressions.CaptureCollection cs = System.Text.RegularExpressions.Regex.Match(str, @"([01]{8})+").Groups[1].Captures;
            byte[] data = new byte[cs.Count];
            for (int i = 0; i < cs.Count; i++)
            {
                data[i] = Convert.ToByte(cs[i].Value, 2);
            }
            return Encoding.Default.GetString(data, 0, data.Length);
        }
    }
}