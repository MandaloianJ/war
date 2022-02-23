using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public int health = 10;
    Animator anim;
    public float death  = 1;
<<<<<<< Updated upstream
    public AudioClip clip;
=======
    public GameObject bloodPrefab;
    public float ata;
>>>>>>> Stashed changes

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(int amountOfDamage)
    {
        health = health - amountOfDamage;
        Debug.Log($"Current health: {health}");
        if(health < 0)
        {
            health = 0;
            Debug.LogWarning($"Current health: {health}");
            float Death = 1;
            anim.SetFloat ("speed", (Death));
<<<<<<< Updated upstream
            AudioSource.PlayClipAtPoint(clip, transform.position);
=======

            
>>>>>>> Stashed changes


        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log($"Obiekt W Zasiêgu: {other.gameObject.name}");
            SceneManager.LoadScene(0);


        }
    }

}
