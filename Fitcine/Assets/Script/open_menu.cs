using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class open_menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void OnClickHome()
    {
        SceneManager.LoadScene("ho-mugamen", LoadSceneMode.Single);
    }
}