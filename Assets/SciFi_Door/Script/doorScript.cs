using UnityEngine;
using System.Collections;

public class doorScript : MonoBehaviour {

    public bool isUnlocked = false;
	// Use this for initialization
	void OnTriggerEnter(Collider col) {
        if (isUnlocked) { 
            GameObject door = GameObject.FindGameObjectWithTag("SF_Door");
            door.GetComponent<Animation>().Play("open");
        }
    }
	
	// Update is called once per frame
	void OnTriggerExit(Collider col) {
        if (isUnlocked)
        {
            GameObject door = GameObject.FindGameObjectWithTag("SF_Door");
            door.GetComponent<Animation>().Play("close");
        }
    }
}
