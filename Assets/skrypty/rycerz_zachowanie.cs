using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rycerz_zachowanie : MonoBehaviour {

    [SerializeField]
    private Transform naboj_spawn;

    [SerializeField]
    private GameObject naboj;

    

    private Animator anim;

    private Vector3 point1;
    private Vector2 point2;
    private float point_kat;

    public float X_pozycja;
    public float Y_pozycja;
    public float opoznienie_naboj;
    float nextSpawn = 0f;

    bool isPaused = false;

    // Use this for initialization
    void Start() {
        anim = GetComponent<Animator>();
        
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

        point1 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        point2 = point1 - transform.position;
        


        int stopien = 0;
        float mnoznik = 1;
        if (point1.x < X_pozycja)
        {
            stopien = -180;
            mnoznik = -1;
        }
        point_kat = Mathf.Atan2((point2.y  - 0.27f) * mnoznik, point2.x) * Mathf.Rad2Deg;

        if (isPaused == false)
        {
            transform.rotation = Quaternion.Euler(stopien, 0, point_kat);
        }
             

        if ((Input.GetMouseButton(0) == true))
        {
           anim.SetBool("Strzal_srodek", true);
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + opoznienie_naboj;
                Strzal();
            }
        }

        if (Input.GetMouseButton(0) == false)
        {
           anim.SetBool("Strzal_srodek", false);
        }

        
	}

    private void Strzal()
    {
        dzwiek.naboj_play_sound();
        GameObject wystrzal = Instantiate(naboj, naboj_spawn.position, naboj_spawn.rotation);
        wystrzal.GetComponent<Rigidbody2D>().velocity = naboj_spawn.right * 15f;
        
    }
}
