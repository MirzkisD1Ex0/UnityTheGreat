using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Newtonsoft.Json;

public class JsonConstructer : MonoBehaviour
{
    #region DataClass
    private class Packages
    {
        public string city;
        public int id;
        public Info info;
    }

    private class Info
    {
        public string weather;
        public string position;
    }
    #endregion

    private void Start()
    {
        BuildJson();
    }

    /// <summary>
    /// 组建一个json
    /// </summary>
    private void BuildJson()
    {
        #region 组建Json头
        Dictionary<string, string> jsonHead = new Dictionary<string, string>();
        jsonHead["token"] = "arandomtoken1998";
        jsonHead["Content-Type"] = "Type/Any";
        #endregion

        #region 组建Json内容
        Packages jsonContent = new Packages();
        jsonContent.city = "上海";
        jsonContent.id = 202001;
        jsonContent.info = new Info();
        jsonContent.info.weather = "晴";
        #endregion

        string tempJson = JsonConvert.SerializeObject(jsonContent); // 将类序列化
        byte[] byteStreaming = Encoding.UTF8.GetBytes(tempJson); // 把序列化后的类转为UTF8比特流
        // JsonConvert;
    }
}