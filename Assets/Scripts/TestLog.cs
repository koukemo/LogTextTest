/**
 * 参考ページ : Hololens2のアプリ内でデバッグログのメッセージとスタックトレースを表示する
 * URL : https://bluebirdofoz.hatenablog.com/entry/2020/09/01/230303
**/

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

// HoloLensフォルダ指定
# if WINDOWS_UWP
using Windows.Storage;
# endif

public class TestLog : MonoBehaviour
{
    void Start()
    {
        Debug.Log("!!! Test Debug Log Message !!!");
        Debug.LogError("!!! Test Error Log Message !!!");

#if WINDOWS_UWP
        var folderpath = KnownFolders.Objects3D.Path;
        var filepath = Path.Combine(folderpath, "TestPB.bin");
        Debug.Log(filepath); 
        Debug.LogError(filepath); 
#endif
    }
}
