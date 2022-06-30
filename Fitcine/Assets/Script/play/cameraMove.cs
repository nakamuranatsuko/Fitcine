using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    //プレイヤーオブジェクト
    public GameObject player;


    // Update is called once per frame
    void Update()
    {

        //transform取得
        Transform cameraTransform = this.transform;

        //座標取得
        Vector3 pos = cameraTransform.position;
        pos.x += 0.02f; //x座標に0.01加算(float)

        //座標を設定
        cameraTransform.position = pos;

        //プレイヤーをカメラと同じx座標にする
        Vector3 playerPos = player.transform.position;
        player.transform.position = new Vector3(cameraTransform.position.x, playerPos.y, playerPos.z);

    }
}
