using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Dukebox : MonoBehaviour {

    AudioSource myAudio;

    public List<AudioClip> audioClips;
    public int trackNumber = 0;

    bool isPlaying;

	// Use this for initialization
	void Start () {
        myAudio = GetComponent<AudioSource>();
        myAudio.loop = true;

        isPlaying = false;
        myAudio.Stop();

        myAudio.clip = audioClips[trackNumber];
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isPlaying = !isPlaying;
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            trackNumber++;

            if (trackNumber > audioClips.Count - 1)
            {
                trackNumber = 0;
            }

            Debug.Log("Track Number: " + trackNumber);
            myAudio.clip = audioClips[trackNumber];
        }

        // If it should be playing but it isn't
        if (isPlaying && !myAudio.isPlaying)
        {
            Debug.Log("Playing");
            myAudio.Play();
        }

        // If it shouldn't be playing but it is
        if (!isPlaying && myAudio.isPlaying)
        {
            Debug.Log("Stop");
            myAudio.Stop();
        }
    }
}
