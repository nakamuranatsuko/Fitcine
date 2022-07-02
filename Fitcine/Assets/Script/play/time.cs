using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class time : MonoBehaviour
{

    //����(�����ݒ�)
    public float countdown = 60.0f;

    //���A�b
    public int min;
    public int sec;

    //�e�L�X�g�I�u�W�F�N�g
    public Text text;
    public Text end;

    //�t���O
    public int flg = 0;


    // Update is called once per frame
    void Update()
    {

        //���Ԃ��I����Ă��Ȃ��Ȃ�
        if(flg == 0)
        {
            //�J�E���g�_�E��
            countdown -= Time.deltaTime;

            //�b(countdown)�𕪁A�b�ɕϊ�
            min = (int)countdown / 60;
            sec = (int)countdown % 60;

            //text�ɕ\��
            text.text = min.ToString("00") + (":") + sec.ToString("00");
        }
        
        //���Ԃ�0�ɂȂ�����^�C���A�b�v���o���āA��ʑJ��
        if(countdown <= 0)
        {
            flg = 1;                            //�t���O�𗧂Ă�
            end.gameObject.SetActive(true);     //�\��
            StartCoroutine("finish");           //�R���[�`���̎��s
        }

    }

    //�R���[�`���̒�`
    IEnumerator finish()
    {
        yield return new WaitForSeconds(2);     //3�b�҂�
        SceneManager.LoadScene("ho-mugamen", LoadSceneMode.Single);
    }

}
