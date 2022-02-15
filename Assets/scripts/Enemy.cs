using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 10;
    Animator anim;
    public float death  = 1;

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
            
        }

    }
}
