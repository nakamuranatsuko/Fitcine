using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cledk_Home : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnClickMenew()
    {
        SceneManager.LoadScene("menew", LoadSceneMode.Single);
    }
}
