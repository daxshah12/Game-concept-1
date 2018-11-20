using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 8f;
    public float lifeDuration;

    private float lifeTimer;

	// Use this for initialization
	void Start () {
        lifeTimer = lifeDuration;
	}

    // Update is called once per frame
    void Update()
    {
        //Make the bullet move;
      transform.position += transform.forward * speed * Time.deltaTime;
        //check if the bullet should be destroyed;
        lifeTimer -= Time.deltaTime;

        if(lifeTimer <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
