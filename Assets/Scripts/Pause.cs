using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject Menu;
    public void PauseMenu()
    {
        Menu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        Menu.SetActive(false);
        Time.timeScale = 1f;
    }
}
