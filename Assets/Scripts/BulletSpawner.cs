using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour {

    public GameObject bullet;
    private float bulletSpawnRate = 0.09f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        bulletSpawnRate = bulletSpawnRate - Time.deltaTime;
        if(Input.GetMouseButton(0) && bulletSpawnRate <= 0)
        {
            Spawn();
            bulletSpawnRate = 0.09f;
        }
		
	}

    void Spawn()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
