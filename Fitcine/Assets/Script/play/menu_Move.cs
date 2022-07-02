using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_Move : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("menew", LoadSceneMode.Single);
        }

    }

    public void onClickmenu()
    {
        SceneManager.LoadScene("menew", LoadSceneMode.Single);
    }

}
