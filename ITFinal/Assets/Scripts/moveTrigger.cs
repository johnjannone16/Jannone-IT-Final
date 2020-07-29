using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTrigger : MonoBehaviour
{
    Renderer rend;
    public static bool inTrigger = false;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        inTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    private void OnTriggerExit(Collider other)
    {
        rend.material.color = Color.white;
        inTrigger = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        rend.material.color = Color.green;
        inTrigger = true;
        
    }
}
