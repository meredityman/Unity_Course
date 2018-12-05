using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Transform cubeTransform = GetComponent<Transform>(); 


        Vector3 translation = new Vector3(0.0f, 0.4f, 0.0f); // Setting out translation
        cubeTransform.Translate( translation ); // Doing translation
        cubeTransform.Rotate(translation); // Doing rotation
        
    }
}
