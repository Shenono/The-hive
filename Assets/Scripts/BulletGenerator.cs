using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject go;
    public GameObject bulletPrefab;
    public float timeRemaining;
    public float time;
    void Start()
    {
        time = timeRemaining;   
    }
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            Shoot();
            timeRemaining = time;
        }

        void Shoot()
        {
            Instantiate(bulletPrefab, go.transform.position, go.transform.rotation);
        }
    }
}
