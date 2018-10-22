using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {


    public float speedX = 4f;
    public float speedY = 4f;
    private float lifeTime = 5f;
    private float bulletDirectionX;
    private float bulletDirectionY;

    Rigidbody2D rb;
	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D>();

        bulletDirectionX = Player.mousePosition.x;
        bulletDirectionY = Player.mousePosition.y;


    }
	
	// Update is called once per frame
	void Update () {

        rb.velocity = new Vector2(Player.mousePosition.x * speedX, Player.mousePosition.y * speedY);

        lifeTime = lifeTime - Time.deltaTime;

        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }

	}
}
