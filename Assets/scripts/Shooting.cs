using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public AudioClip clip;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GetComponent<TowerShoting>().enabled = true;
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }

        if (Input.GetKeyUp(KeyCode.Z))
        {
            GetComponent<TowerShoting>().enabled = false;
        }
    }


}
