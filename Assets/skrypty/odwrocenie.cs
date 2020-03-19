using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class odwrocenie : MonoBehaviour {

    public float X_odwrocenie;
    private Camera cam;
    private Vector3 point;

    bool isPaused = false;

    // Use this for initialization
    void Start () {
        cam = Camera.main;
    }

    void OnGUI()
    {
        Event currentEvent = Event.current;

        Vector2 mousePos = new Vector2();
        mousePos.x = currentEvent.mousePosition.x;
        mousePos.y = cam.pixelHeight - currentEvent.mousePosition.y;

        point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));
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

        int stopien = 0;
        if (point.x < X_odwrocenie)
        {
            stopien = -180;
        }

        if (isPaused == false)
        {
            transform.localRotation = Quaternion.Euler(0, stopien, 0);
        }
    }
}
