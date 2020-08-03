using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour
{
    Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        openDoor();
    }

    void openDoor()
    {
        if(doorOpening.inTrigger == true)
        {
            anim.SetBool("DoorOpen", true);
            Debug.Log("Door Open");
        }
        else
        {
            anim.SetBool("DoorOpen", false);
            Debug.Log("Door Close");
        }

    }

}
