using UnityEngine;
using System.Collections;

public class FireTrigger : MonoBehaviour {

    public GameObject TextObject1;
    public GameObject TextObject2;
    public GameObject fireSystem;
	// Use this for initialization
	void OnTriggerEnter (Collider col) {
        TextObject1.SetActive(true);
        TextObject2.SetActive(true);
        fireSystem.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
