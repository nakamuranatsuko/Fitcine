using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class time : MonoBehaviour
{

    //時間(初期設定)
    public float countdown = 60.0f;

    //分、秒
    public int min;
    public int sec;

    //テキストオブジェクト
    public Text text;
    public Text end;

    //フラグ
    public int flg = 0;


    // Update is called once per frame
    void Update()
    {

        //時間が終わっていないなら
        if(flg == 0)
        {
            //カウントダウン
            countdown -= Time.deltaTime;

            //秒(countdown)を分、秒に変換
            min = (int)countdown / 60;
            sec = (int)countdown % 60;

            //textに表示
            text.text = min.ToString("00") + (":") + sec.ToString("00");
        }
        
        //時間が0になったらタイムアップを出して、画面遷移
        if(countdown <= 0)
        {
            flg = 1;                            //フラグを立てる
            end.gameObject.SetActive(true);     //表示
            StartCoroutine("finish");           //コルーチンの実行
        }

    }

    //コルーチンの定義
    IEnumerator finish()
    {
        yield return new WaitForSeconds(2);     //3秒待つ
        SceneManager.LoadScene("ho-mugamen", LoadSceneMode.Single);
    }

}
