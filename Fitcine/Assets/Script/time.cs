using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class time : MonoBehaviour
{

    //����(�����ݒ�)
    public float countdown = 180.0f;

    //���A�b
    public int min;
    public int sec;

    //�e�L�X�g�I�u�W�F�N�g
    public Text text;


    // Update is called once per frame
    void Update()
    {
        //�J�E���g�_�E��
        countdown -= Time.deltaTime;

        //�b(countdown)�𕪁A�b�ɕϊ�
        min = (int)countdown / 60;
        sec = (int)countdown % 60;

        //text�ɕ\��
        text.text = min.ToString("00") + (":") + sec.ToString("00");
        
        //���Ԃ�0�ɂȂ������ʑJ��
        if(countdown <= 0)
        {
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        }

    }
}
