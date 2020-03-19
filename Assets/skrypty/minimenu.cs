using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimenu : MonoBehaviour {
    bool isPaused ;

    [SerializeField]
    private GameObject meni;
   


    // Use this for initialization
    void Start () {
        meni.SetActive(false);
        isPaused = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("escape"))
        {

            if (isPaused == true)
            {
                meni.SetActive(false);
                isPaused = false;
            }
            else
            {
                meni.SetActive(true);
                isPaused = true;
            }
        }
    }
}
