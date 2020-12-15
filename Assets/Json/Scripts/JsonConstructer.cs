using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Newtonsoft.Json;

/// <summary>
/// 
/// </summary>
public class JsonConstructer : MonoBehaviour
{
    #region 数据类
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
        jsonContent.id = 2020001;
        jsonContent.info = new Info();
        jsonContent.info.weather = "晴";
        jsonContent.info.position = "昆山南,嘉兴北";
        #endregion

        string serializeJson = JsonConvert.SerializeObject(jsonContent); // 将类序列化 // Newtonsoft.Json
        byte[] jsonStreaming = Encoding.UTF8.GetBytes(serializeJson); // 把序列化后的类转为UTF8比特流

        WhatHaveWeGotHere(serializeJson);
        SendJsonToSomeWhere(jsonHead, jsonStreaming);
    }

    /// <summary>
    /// 把Json发粗去
    /// </summary>
    /// <param name="head"></param>
    /// <param name="content"></param>
    /// <returns></returns>
    private IEnumerator SendJsonToSomeWhere(Dictionary<string, string> head, byte[] content)
    {
        WWW www = new WWW("https://github.com", content, head); // 向HTTP服务器提交Post数据
        yield return www;
        if (www.error != null)
        {
            Debug.Log(www.error);
            yield break;
        }
        Debug.Log(www.text);
    }

    /// <summary>
    /// 看一眼Json内容填错了没 // 反序列化
    /// </summary>
    private void WhatHaveWeGotHere(string serializeJson)
    {
        Packages tempPackages = JsonConvert.DeserializeObject<Packages>(serializeJson);
        Debug.Log(tempPackages.id); // 偷看一眼id
    }
}