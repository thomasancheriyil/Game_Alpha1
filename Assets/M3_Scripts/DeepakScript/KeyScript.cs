using UnityEngine;
using System.Collections;

public class KeyScript : MonoBehaviour {

    public GameObject doorObject;
	// Use this for initialization
	void OnTriggerEnter (Collider col) {
        GameObject redLight = GameObject.FindGameObjectWithTag("RedLight");
        GameObject greenLight = GameObject.FindGameObjectWithTag("GreenLight");
        redLight.GetComponent<Light>().enabled = false;
        greenLight.GetComponent<Light>().enabled = true;
        this.GetComponent<Renderer>().enabled = false;
        this.GetComponent<Light>().enabled = false;
        doorObject.GetComponent<doorScript>().isUnlocked = true;
    }
	
}
