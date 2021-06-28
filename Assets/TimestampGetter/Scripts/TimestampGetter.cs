using System.Collections;
using UnityEngine;

using Newtonsoft.Json.Linq;
using System;
using UnityEngine.Networking;

namespace TimestampGetter
{
    /// <summary>
    /// 获取时间戳
    /// </summary>
    /// https://tool.lu/timestamp/
    public class TimestampGetter : MonoBehaviour
    {
        public string StampURL = "http://api.m.taobao.com/rest/api3.do?api=mtop.common.getTimestamp"; // 时间戳提供者

        private void Start()
        {
            StartCoroutine(GetTimeStamp(StampURL));
        }

        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <returns></returns>
        private IEnumerator GetTimeStamp(string stampURL)
        {
            UnityWebRequest webRequest = UnityWebRequest.Get(stampURL);
            yield return webRequest.SendWebRequest();
            if (webRequest.result == UnityWebRequest.Result.ProtocolError || webRequest.result == UnityWebRequest.Result.ConnectionError)
            {
                Debug.Log(webRequest.error);
            }

            JObject jb = JObject.Parse(webRequest.downloadHandler.text);

            long longTime = long.Parse(jb["data"]["t"].ToString());
            Debug.Log("Timestamp: " + longTime);

            string stringTime = jb["data"]["t"].ToString();
            Debug.Log("DataTime: " + ConvertStringToDateTime(stringTime));
        }

        /// <summary>
        /// 时间戳转为C#格式时间
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <returns></returns>
        private DateTime ConvertStringToDateTime(string timeStamp)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow);
        }
    }
}