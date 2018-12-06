using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    public float speed = 10.0f;

    Material mat;
    Color col;

	// Use this for initialization
	void Start () {
        mat = GetComponent<MeshRenderer>().materials[0];
	}
	
	// Update is called once per frame
	void Update () {
        col = Color.HSVToRGB(  (Mathf.Sin(Time.fixedTime / speed) * 0.5f) + 0.5f , 1.0f, 1.0f);
        mat.color = col;

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

	}
}
