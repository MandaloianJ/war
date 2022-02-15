using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public int amountOfDamage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Skeleton")
        {
            Debug.Log("trafiony");
            other.GetComponent<Enemy>().Damage(amountOfDamage);
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }


}
