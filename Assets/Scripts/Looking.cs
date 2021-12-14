using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looking : MonoBehaviour
{
    private void Start()
    {
        gameObject.transform.rotation = Quaternion.Euler(0, 90, 0);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 270, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.transform.rotation = Quaternion.Euler(0,90, 0);
        }
    }
}
