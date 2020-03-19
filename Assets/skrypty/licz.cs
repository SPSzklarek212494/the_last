using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class licz : MonoBehaviour {

    public static int zabici;
    public static float zycie;

    Text zabiciText;

    [SerializeField]
    private GameObject game_over_meni;


    // Use this for initialization
    void Start () {
        zabici = 0;
        zycie = 100;
        zabiciText = GetComponent<Text>();
        game_over_meni.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
        zabiciText.text = "HEALTH: "+ zycie.ToString() +"\nKILLS: " + zabici.ToString();

        if (zycie == 0)
        {
            game_over_meni.SetActive(true);
        }
    }
}
