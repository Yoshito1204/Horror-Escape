using UnityEngine;
using UnityEditor;
using System;

[InitializeOnLoad]
public class SetJavaHomeEditor
{
    //初回起動チェック用ダミーファイルパス
    static readonly string tempFilePath = "Temp/SetJavaHomeEditor_InitFlag";

    static SetJavaHomeEditor()
    {
        //初回起動（Fileがあるか）チェック
        if (System.IO.File.Exists(tempFilePath) == true)
        {
            //ダミーファイルが既にあるので以降の処理スキップ
            return;
        }

        Debug.Log("SetJavaHomeEditor 初回起動チェック用ダミーファイル作成");
        System.IO.File.Create(tempFilePath);

        //初回起動時のJAVA_HOMEパス
        Debug.Log($"SetJavaHomeEditor JAVA_HOME in editor was: {Environment.GetEnvironmentVariable("JAVA_HOME")}");
    
        string newJDKPath = EditorApplication.applicationPath.Replace("Unity.app","PlaybackEngines/AndroidPlayer/OpenJDK");

        if(Environment.GetEnvironmentVariable("JAVA_HOME") != newJDKPath)
        {
            //JAVA_HOME パス書き換え
            Environment.SetEnvironmentVariable("JAVA_HOME",newJDKPath);
        }
        //書き換え後のJAVA_HOMEパス
        Debug.Log($"SetJavaHomeEditor JAVA_HOME in editor set to: { Environment.GetEnvironmentVariable("JAVA_HOME")}");
    }
}