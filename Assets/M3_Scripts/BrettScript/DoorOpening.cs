using UnityEngine;
using System.Collections;

public class DoorOpening : MonoBehaviour {

	AudioSource doorAudio;
    GameObject startTime;

	void Awake(){

		doorAudio = GetComponent<AudioSource> ();
        startTime = GameObject.Find("/Canvas/GameTime");
    }
	void OnCollisionEnter(Collision other){

		//check to see if collision is with the player object
		if (other.gameObject.CompareTag ("Player")) {
			doorAudio.Play ();
            startTime.SetActive(true);
		}

	}
}
