using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiSpawnerScript : MonoBehaviour {

    
    public GameObject enemy;
    public float odkad;
    public float dokad; 
    float randY;
    Vector2 whereToSpawn;
    public float spawn_od;
    public float spawn_do;
    float nextSpawn = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + Random.Range(spawn_od, spawn_do);
            randY = Random.Range(odkad, dokad);
            whereToSpawn = new Vector2(transform.position.x, randY);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }

	}
}
