using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShot2 : MonoBehaviour
{
    // Start is called before the first frame update
    private void Update()
    {
        // スペースキーが押されたら
        if (Input.GetKeyDown(KeyCode.A))
        {
            // スクリーンショットを保存
            CaptureScreenShot("ScreenShot.png");
        }
    }

    // 画面全体のスクリーンショットを保存する
    private void CaptureScreenShot(string filePath)
    {
        ScreenCapture.CaptureScreenshot(filePath);
    }
}