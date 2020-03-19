using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

	// Use this for initialization
	//void Start () {
		
	//}

    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "StartButton":
                SceneManager.LoadScene ("SampleScene");
                
                break;

        }
    }

    public void wyjscie()
    {
        Application.Quit();
    }
	// Update is called once per frame
	//void Update () {
		
	//}
}
