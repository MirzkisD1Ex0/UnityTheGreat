using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Newtonsoft.Json;

/// <summary>
/// 
/// </summary>
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
        jsonContent.info.position = "苏州太仓昆山和嘉兴的旁边吧";
        #endregion

        string tempJson = JsonConvert.SerializeObject(jsonContent); // 将类序列化
        byte[] byteStreaming = Encoding.UTF8.GetBytes(tempJson); // 把序列化后的类转为UTF8比特流
        // JsonConvert;
    }

    // private IEnumerator SendJson()
    // {
    //     WWW www = new WWW("https://baidu.com", bytestreaming, headers); // 向HTTP服务器提交Post数据
    //     yield return www;
    //     if (www.error != null)
    //     {
    //         Debug.Log(www.error);
    //         yield break;
    //     }

    //     #region 解析结果
    //     JObject obj = JObject.Parse(www.text);
    //     string replyString = obj["suggested_response"][0]["response"][0]["msg_body"]["text"]["content"].ToString();
    //     Tool.Log("吾来返回结果=" + replyString, 0);
    //     #endregion

    //     zddCommandResponce.Response(replyString);
    // }
}