using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dzwiek : MonoBehaviour {


    static AudioSource dzwiek_source;

    public static AudioClip[] naboj_dzwiek_clip;

    public static AudioClip[] zombi_death_dzwiek_clip;

    static int wybor;
    

    // Use this for initialization
    void Start () {


        dzwiek_source = GetComponent<AudioSource>();
        naboj_dzwiek_clip = Resources.LoadAll<AudioClip>("ak_shot");
        zombi_death_dzwiek_clip = Resources.LoadAll<AudioClip>("zombi_death");
    }
	
	// Update is called once per frame
	void Update () {

    }

    public static void naboj_play_sound()
    {
        dzwiek_source.PlayOneShot(naboj_dzwiek_clip[0]);
    }

    public static void zombi_death_play_sound()
    {
        wybor = Random.Range(0, 2);
        dzwiek_source.PlayOneShot(zombi_death_dzwiek_clip[wybor]);
    }
}
