using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyEnterScript : MonoBehaviour
{


    Renderer rend;
    public Rigidbody rb;
    public static bool inTrigger = false;
    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rb = GetComponent<Rigidbody>();
        inTrigger = false;
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

    }

    private void OnTriggerExit(Collider rb)
    {
        rend.material.color = Color.white;
        inTrigger = false;
    }

}
