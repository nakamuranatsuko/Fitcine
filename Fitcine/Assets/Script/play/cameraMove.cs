using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    //�v���C���[�I�u�W�F�N�g
    public GameObject player;


    // Update is called once per frame
    void Update()
    {

        //transform�擾
        Transform cameraTransform = this.transform;

        //���W�擾
        Vector3 pos = cameraTransform.position;
        pos.x += 0.02f; //x���W��0.01���Z(float)

        //���W��ݒ�
        cameraTransform.position = pos;

        //�v���C���[���J�����Ɠ���x���W�ɂ���
        Vector3 playerPos = player.transform.position;
        player.transform.position = new Vector3(cameraTransform.position.x, playerPos.y, playerPos.z);

    }
}
