﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimatorScript : MonoBehaviour
{
    Animator anim;
    public Rigidbody player;
    public GameObject playerOBJ;
    public float speed = 1;
    
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        pushTrigger();
        ladderTrigger();
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

    void ladderTrigger()
    {
        if (ladderClimb.canClimb == true)
        {
            if (Input.GetKey(KeyCode.F))
            {
                anim.SetBool("isClimbing", true);
                player.useGravity = false;
                player.isKinematic = true;               
                Debug.Log("Started Climbing");
            }
            if (ladderClimb.canClimb == true)
            {

                Debug.Log("Climbing");
                if (Input.GetKey(KeyCode.W) && ladderExit.exitLadder == false)
                {
                    playerOBJ.transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * speed);
                    anim.SetFloat("climbSpeed", 1);

                }
                else if (Input.GetKeyUp(KeyCode.W))
                {
                    anim.SetFloat("climbSpeed", 0.5f);
                }

                if (Input.GetKey(KeyCode.S))
                {
                    playerOBJ.transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * speed);
                    anim.SetFloat("climbSpeed", 0.1f);
                }
                else if (Input.GetKeyUp(KeyCode.S))
                {
                    anim.SetFloat("climbSpeed", 0.5f);
                }

                if(ladderExit.exitLadder == true)
                {
                    anim.SetBool("climbExit", true);
                    anim.SetBool("isClimbing", false);
                    
                    
                    playerOBJ.transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * speed);
                    Invoke("translateUp", 2);
                   
                }

                if (ladderExit.exitLadder == false)
                {
                    anim.SetBool("climbExit", false);
                    
                    
                }

            }
            else if (ladderClimb.canClimb == false)
            {
                anim.SetBool("isClimbing", false);
                player.useGravity = true;
                Debug.Log("Ended Climbing");
                player.isKinematic = false;

            }

            if(stopper.nearGround == true && Input.GetKey(KeyCode.F) && Input.GetKey(KeyCode.S))
            {
                anim.SetBool("isClimbing", false);
                player.useGravity = true;
                player.isKinematic = false;
            }

        }
    }
    private void translateUp()
    {
        playerOBJ.transform.Translate(new Vector3(0, 0, 0.85f) * Time.deltaTime * speed);
        player.isKinematic = false;
        player.useGravity = true;
    }
}
