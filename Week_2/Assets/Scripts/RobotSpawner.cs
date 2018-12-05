using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotSpawner : MonoBehaviour {

    public GameObject robotPrefab;
    public float spawnAreaSize = 2.0f;


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newRobot = Instantiate(robotPrefab, this.transform); // Instantiating new object


            // Moving it in the x and z direction by a random amount
            newRobot.transform.Translate(new Vector3(spawnAreaSize * Random.value, 0.0f, spawnAreaSize * Random.value)); 
        }        
    }
}
