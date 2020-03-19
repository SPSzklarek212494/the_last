using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAuza : MonoBehaviour {

    bool isPaused = false;

    // Use this for initialization
    void Start () {
        Time.timeScale = 1;
    }

	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("escape"))
        {

            if (isPaused == true)
            {
                Time.timeScale = 1;
                isPaused = false;
            }
            else
            {
                Time.timeScale = 0;
                isPaused = true;
            }
        }

        if (licz.zycie == 0)
        {
            Time.timeScale = 0;
        }

    }
}
