using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    float rotationX;
    float rotationY;

    public GameObject prefab;

	// Use this for initialization
	void Start () {
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
        rotationX += Input.GetAxis("Mouse X");
        rotationY += Input.GetAxis("Mouse Y");

        transform.rotation = Quaternion.AngleAxis(rotationX, Vector3.up);
        transform.rotation *= Quaternion.AngleAxis(rotationY, Vector3.left);


        if(Input.GetButton("Fire1"))
        {
            GameObject newPrefab = Instantiate(prefab); 
            newPrefab.transform.rotation = this.transform.rotation;

            this.transform.Translate(new Vector3(0, 0, 1.0f / 10.0f) );

            //transform.Translate(Vector3.forward);
        }
        
	}
}
