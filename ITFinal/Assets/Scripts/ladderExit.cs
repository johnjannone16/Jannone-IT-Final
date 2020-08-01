using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladderExit : MonoBehaviour
{

    Renderer rend;
    public Rigidbody rb;
    public static bool inTrigger = false;
    
    public static bool exitLadder;
    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rb = GetComponent<Rigidbody>();
        inTrigger = false;
        exitLadder = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider rb)
    {
        rend.material.color = Color.red;
        inTrigger = true;
        Debug.Log("intrigger");
        exitLadder = true;
    }

    private void OnTriggerExit(Collider rb)
    {
        rend.material.color = Color.white;
        inTrigger = false;
        exitLadder = false;
        ladderClimb.canClimb = false;
    }
}
