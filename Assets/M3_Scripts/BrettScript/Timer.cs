using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time;                         //public variable to set time to complete level
    private GameObject gameTime;               //GUI game object to update
    private Text gameTimeText;
        
    private KayaIsoLocomotion playerMovement;  //player movement component to update ragdoll

    // Use this for initialization
    void Awake()
    {
        gameTime = GameObject.Find("/Canvas/GameTime");
        gameTimeText = gameTime.GetComponent<Text>();
        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<KayaIsoLocomotion>();
    }
     void Start()
    {
        gameTime.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time = time - Time.deltaTime;
        if (time <= 0.0f)
        {
            time = 0.0f;
            playerMovement.setRagdoll();
        }

        if (time <= 10.0f)
            gameTimeText.color = Color.red;

        gameTimeText.text = "Time Remaining: " + Mathf.Round(time);
    }
}
