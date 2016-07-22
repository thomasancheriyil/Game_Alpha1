using UnityEngine;
using System.Collections;

public class SimpleTrigger : MonoBehaviour {
    public GameObject objectToEnable;

	void OnTriggerEnter () {
        objectToEnable.SetActive(true);
    }
	
	void OnTriggerExit() {
        objectToEnable.SetActive(false);
    }
}
