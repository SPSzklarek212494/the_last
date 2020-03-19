using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mur : MonoBehaviour {

    public int punkty_zycia;
    public int odejmowane_punkty;

    public int ilosc_zabitych = 0;
    Collider2D murek;

    int ilosc;

    // Use this for initialization
    void Start () {
        murek = GetComponent<PolygonCollider2D>();

        InvokeRepeating("LaunchProjectile", 0.01f, 1.0f);
    }

    void OnGUI()
    {
        Event currentEvent = Event.current;
        
        
        GUILayout.BeginArea(new Rect(20, 20, 250, 120));
        GUILayout.Label("HEALTH:\t" + punkty_zycia);
        GUILayout.Label("KILLED: " + ilosc_zabitych);


        // GUILayout.Label("World position: " + point.ToString("F3"));
        GUILayout.EndArea();
         
    }

    
    void LaunchProjectile()
    {

        ilosc = 0;
        GameObject[] otherObjects = GameObject.FindGameObjectsWithTag("wrog");

        foreach (GameObject obj in otherObjects)
        {
            if (murek.IsTouching(obj.GetComponent<PolygonCollider2D>()) == true)
            {
                ilosc++;
            }
        }

        punkty_zycia = punkty_zycia - (odejmowane_punkty * ilosc);
    }
    

    // Update is called once per frame
    void Update () {

    }
}
