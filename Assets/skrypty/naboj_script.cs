using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class naboj_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
        InvokeRepeating("Wymarcie", 5f, 0.1f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void Wymarcie()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.gameObject.tag)
        {
            case "wrog":
                Destroy(gameObject);
                break;
            
        }

        
       
    }
}
