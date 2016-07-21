using UnityEngine;
using UnityEditor;
using System.Collections;

public class HoldCharacter : MonoBehaviour {

    public GameObject player;
    void OnTriggerEnter(Collider col)
    {
        GameObject temp = col.transform.gameObject;
        player.transform.SetParent(gameObject.transform);
    }

    void OnTriggerExit(Collider col)
    {
        col.transform.parent = null;
    }

}
