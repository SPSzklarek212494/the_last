using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_over_menu : MonoBehaviour {

    Text koniecText;
    // Use this for initialization
    void Start () {

        koniecText = GetComponent<Text>();

    }
	
	// Update is called once per frame
	void Update () {
        koniecText.text = "GAME OVER"  + "\nYou killed " + licz.zabici.ToString() +" enemies";
    }
}
