using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public GameObject bulletPrefab;
    public Camera playerCamera;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletobject = Instantiate(bulletPrefab);
            bulletobject.transform.position = playerCamera.transform.position + playerCamera.transform.forward; ;
            bulletobject.transform.forward = playerCamera.transform.forward;
        }

    }
}
