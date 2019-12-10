using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{

    public KeyCode PauseButton;
    public bool Pause;

    public GameObject PauseMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(PauseButton) && !Pause)
        {
            Time.timeScale = 0f;
            Pause = true;
            PauseMenu.SetActive(true);
        }else
        if(Input.GetKeyDown(PauseButton) && Pause)
        {
            Time.timeScale = 1f;
            Pause = false;
            PauseMenu.SetActive(false);
        }
    }
}
