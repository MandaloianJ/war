using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerGame : MonoBehaviour
{
    public GameObject play;
    public GameObject Stop;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameTime()
    {
        play.SetActive(false);
        Time.timeScale = 0;
        Stop.SetActive(true);
    }

    public void GameOpen()
    {
        play.SetActive(true);
        Time.timeScale = 1;
        Stop.SetActive(false);
    }

}
