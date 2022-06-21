using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class time : MonoBehaviour
{

    //時間(初期設定)
    public float countdown = 180.0f;

    //分、秒
    public int min;
    public int sec;

    //テキストオブジェクト
    public Text text;


    // Update is called once per frame
    void Update()
    {
        //カウントダウン
        countdown -= Time.deltaTime;

        //秒(countdown)を分、秒に変換
        min = (int)countdown / 60;
        sec = (int)countdown % 60;

        //textに表示
        text.text = min.ToString("00") + (":") + sec.ToString("00");
        
        //時間が0になったら画面遷移
        if(countdown <= 0)
        {
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        }

    }
}
