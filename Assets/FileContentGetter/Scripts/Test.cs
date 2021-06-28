using UnityEngine;

/// <summary>
/// 文件读取测试
/// </summary>
namespace FileContentGetter
{
    public class Test : MonoBehaviour
    {
        private void Start()
        {
            string path = Application.streamingAssetsPath + "/TextStorage/" + "readme.txt"; // 文件路径记得带后缀名
            string content = FileContentGetter.GetFileContent(path, 1); // 读取第一行
            Debug.Log(content);
        }
    }
}