using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class TriggerMove : MonoBehaviour
{

    public float thrust;
    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("moveObj", 2);

    }

    private void FixedUpdate()
    {

    }
    void moveObj()
    {
        if (moveTrigger.inTrigger == true && Input.GetKey(KeyCode.F) == true && Input.GetKey(KeyCode.W) == true && fireflyChangeMat.abilityNum == 3)
        {
            var head = GameObject.FindGameObjectWithTag("Head");

            var targetDirection = head.transform.forward;
            rb.AddForce(targetDirection * thrust / Time.deltaTime);

        }
    }
}

