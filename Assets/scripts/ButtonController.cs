using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonController : MonoBehaviour
{


    // Update is called once per frame
    public void ZmienScene()
    {
        SceneManager.LoadScene(1);
    }

    public void Wyjdz()
    {
        Application.Quit();
    }
}



