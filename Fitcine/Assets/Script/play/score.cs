using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    //�v���C���[�I�u�W�F�N�g
    public GameObject player;

    //�e�L�X�g�I�u�W�F�N�g
    public Text scoreText;

    //�X�R�A�ϐ�
    public static int Score = 0;


    // Update is called once per frame
    void Update()
    {

        //�v���C���[�A��ނ�transform�擾
        Transform playerTransform = player.transform;
        Transform guzaiTransform = this.transform;

        //�v���C���[�A��ނ̍��W�擾
        Vector3 pos_p = playerTransform.position;
        Vector3 pos_g = guzaiTransform.position;

        //�����Axy���W���͈͓��Ȃ�A��\���ɂ��ăX�R�A���P���₷
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

    //�Q�b�^�[�֐�
    public static int getScore()
    {
        return Score;
    }

}
