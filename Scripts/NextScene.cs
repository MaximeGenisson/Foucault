using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("TitleScreen2");
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SceneManager.LoadScene("TitleScreen2");
        }
    }
}
