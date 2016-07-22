using UnityEngine;
using System.Collections;

public class HoldCharacter : MonoBehaviour {

    public GameObject player;
    void OnTriggerEnter(Collider col)
    {
        player.transform.SetParent(gameObject.transform);
    }

    void OnTriggerStay(Collider col)
    {
        player.transform.SetParent(gameObject.transform);
    }

    void OnTriggerExit(Collider col)
    {
        player.transform.parent = null;
    }

}
