using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject panelInstrukcja;


    // Update is called once per frame
    public void ZmienScene()
    {
        SceneManager.LoadScene(1);
    }

    public void Wyjdz()
    {
        Application.Quit();
    }



    public void PanelClose()
    {
        panelInstrukcja.SetActive(false);
    }

    public void PanelOpen()
    {
        panelInstrukcja.SetActive(true);
    }

    public void PanelMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }


}




