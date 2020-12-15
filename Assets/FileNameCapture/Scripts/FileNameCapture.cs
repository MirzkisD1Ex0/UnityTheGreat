using UnityEngine;
using System.IO;

/// <summary>
/// 获取某个目录下指定类型的文件名
/// </summary>
public class FileNameCapture : MonoBehaviour
{
    public string[] Files; // 储存文件名的数组

    private string fileStoragePath = Application.streamingAssetsPath + "/" + "VideoStorage"; // 文件路径
    private string fileSuffix = ".mp4"; // 文件后缀名

    private void Start()
    {
        GetFileName(fileStoragePath, fileSuffix, ref Files);
    }

    /// <summary>
    /// 获取路径下全部指定类型的文件名
    /// </summary>
    /// <param name="path">路径</param>
    /// <param name="suffix">后缀名</param>
    /// <param name="files">用以存储文件名的数组</param>
    private void GetFileName(string path, string suffix, ref string[] files)
    {
        if (!Directory.Exists(path)) // 如果路径不存在 // 返回 0
        {
            return;
        }
        DirectoryInfo directoryInfo = new DirectoryInfo(path); // 获取文件信息
        FileInfo[] fileInfos = directoryInfo.GetFiles("*", SearchOption.AllDirectories);

        #region 获取文件数组尺寸
        int arraySize = 0;
        for (int i = 0; i < fileInfos.Length; i++)
        {
            if (fileInfos[i].Name.EndsWith(fileSuffix))
            {
                arraySize++;
                continue;
            }
        }
        #endregion

        files = new string[arraySize]; // 新建数组

        #region 将符合要求的文件名存至数组
        int arrayIndex = 0;
        for (int i = 0; i < fileInfos.Length; i++)
        {
            if (fileInfos[i].Name.EndsWith(fileSuffix))
            {
                files[arrayIndex++] = fileInfos[i].Name; // 把符合要求的文件名存储至数组中
                continue;
            }
        }
        #endregion
        return;
    }
}