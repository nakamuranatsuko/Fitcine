using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    //プレイヤーオブジェクト
    public GameObject player;

    //テキストオブジェクト
    public Text scoreText;

    //スコア変数
    public static int Score = 0;


    // Update is called once per frame
    void Update()
    {

        //プレイヤー、具材のtransform取得
        Transform playerTransform = player.transform;
        Transform guzaiTransform = this.transform;

        //プレイヤー、具材の座標取得
        Vector3 pos_p = playerTransform.position;
        Vector3 pos_g = guzaiTransform.position;

        //もし、xy座標が範囲内なら、非表示にしてスコアを１増やす
        if (pos_g.x - 1 <= pos_p.x && pos_g.x + 1 >= pos_p.x && pos_g.y - 1 <= pos_p.y && pos_g.y + 1 >= pos_p.y)
        {
            this.gameObject.SetActive(false);
            Score++;
            if (Score < 10)
            {
                scoreText.text = ("Score:") + Score.ToString("0");
            }
            else
            {
                scoreText.text = ("Score:") + Score.ToString("00");
            }

        }

    }

    //ゲッター関数
    public static int getScore()
    {
        return Score;
    }

}
