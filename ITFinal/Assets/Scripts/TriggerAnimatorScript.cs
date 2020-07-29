using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimatorScript : MonoBehaviour
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
        pushTrigger();
    }
              void pushTrigger()
    {
        if (moveTrigger.inTrigger == true && Input.GetKey(KeyCode.F) == true)
        {
            anim.SetBool("isPushing", true);
        }
        else
        {
            anim.SetBool("isPushing", false);
        }
    }
}
