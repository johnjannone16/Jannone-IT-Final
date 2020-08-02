using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killTrigger : MonoBehaviour
{
    Renderer rend;
    public Rigidbody rb;
    public static bool inKillTrigger = false;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rb = GetComponent<Rigidbody>();
        inKillTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider rb)
    {
        rend.material.color = Color.red;
        inKillTrigger = true;
        Debug.Log("intrigger");

    }

    private void OnTriggerExit(Collider rb)
    {
        rend.material.color = Color.white;
        inKillTrigger = false;
    }
}
