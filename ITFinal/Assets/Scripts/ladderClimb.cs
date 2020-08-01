using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladderClimb : MonoBehaviour
{
    public GameObject playerOBJ;
    public static bool canClimb;
    public static bool exitLadder;
    public float speed = 1;
    public Rigidbody playerRB;
    private GameObject ladderExit;
  

    
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        canClimb = false;
        exitLadder = false;
        playerOBJ = GameObject.Find("Player");
        ladderExit = GameObject.Find("LadderExit");
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == playerOBJ)
        {
            canClimb = true;
            exitLadder = false;
        }

    }

 

    private void OnTriggerEnter(Collider other)
    {
        ladderClimb.canClimb = false;
        exitLadder = true;
        Debug.Log("exit");
    }
}
