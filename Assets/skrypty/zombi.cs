using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombi : MonoBehaviour {

    public float predkosc;
    public int obrazenia;
    public int zycie;
    float next_obrazenie = 0f;

    public float spawn_od;
    public float spawn_do;

    private GameObject murek;

    private Animator anim;
	
	

    // Use this for initialization
    void Start () {

       // transform.localScale = new Vector3( (GetComponent<Rigidbody2D>().position.y / spawn_do), (GetComponent<Rigidbody2D>().position.y / spawn_do), 0);
		anim = GetComponent<Animator>();
        murek = GameObject.FindGameObjectWithTag("mur");
        anim.SetBool("ruch", true);

    }


    void OnEnable()
    {
        GameObject[] otherObjects = GameObject.FindGameObjectsWithTag("wrog");

        foreach (GameObject obj in otherObjects)
        {
            Physics2D.IgnoreCollision(obj.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

    }
	
	

    // Update is called once per frame
    void Update () {
        
        GetComponent<Rigidbody2D>().velocity = new Vector2(predkosc, GetComponent<Rigidbody2D>().velocity.y);

        if (GetComponent<PolygonCollider2D>().IsTouching(murek.GetComponent<PolygonCollider2D>()) == true)
        {
            if (Time.time > next_obrazenie)
            {
                next_obrazenie = Time.time + 1f;
                licz.zycie -= obrazenia;
            }
        }
		
		
		
    }
	
	

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "naboj")
        {
            zycie--;

            if (zycie <= 0)
            {
				anim.SetBool("ruch", false);
				anim.SetBool("koniec", true);
				predkosc = 0.0f;
                dzwiek.zombi_death_play_sound();
                licz.zabici++;
				
                Destroy(gameObject);
            }
        }
    }
	
	
}
