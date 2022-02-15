using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShoting : MonoBehaviour
{
    public GameObject bulletPrefab;

    private void OnEnable()
    {
        InvokeRepeating("Fire", 0, 0.5f);
    }

    private void OnDisable()
    {
        CancelInvoke("Fire");
    }

    void Fire()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }
}
