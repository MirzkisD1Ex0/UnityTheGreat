
using UnityEngine;
using System;

namespace FunctionFormalParameter
{
    /// <summary>
    /// 带有函数形参的函数
    /// </summary>
    public class FunctionFormalParameter : MonoBehaviour
    {
        private void Start()
        {
            Trigger(true, PrintString);
        }

        /// <summary>
        /// 函数
        /// </summary>
        /// <param name="tempString"></param>
        /// <param name="method"></param>
        private void Trigger(bool tempBool, Action method)
        {
            if (tempBool)
            {
                method();
            }
            return;
        }

        /// <summary>
        /// 被传入的形参
        /// </summary>
        private void PrintString()
        {
            Debug.Log("输出这句话");
            return;
        }
    }
}