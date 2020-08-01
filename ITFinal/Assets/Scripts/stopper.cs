using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopper : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject player;
    public static bool nearGround;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        nearGround = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S) && nearGround == true)
        {
            player.transform.Translate(Vector3.up * Time.deltaTime * 1, Space.World);
        }

        
    }

    private void OnTriggerEnter(Collider other)
    {
        nearGround = true;
        
    }


    private void OnTriggerExit(Collider other)
    {
        nearGround = false;
    }
}
