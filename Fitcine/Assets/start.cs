using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{

    private Rigidbody2D rbody2D;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickStart()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        //‰æ–Ê‘JˆÚ
    }
}
