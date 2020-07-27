using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Transform cam;

    public float speed;
    public float turnspeed;
    Animator anim;
    Rigidbody rigidBody;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody>();
        cam = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector3 dir = (cam.right * Input.GetAxis("Horizontal")) + (cam.forward * Input.GetAxis("Vertical"));

        dir.y = 0;

        if(Input.GetAxis("Horizontal") !=0 || Input.GetAxis("Vertical") != 0)
        {

            rigidBody.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), turnspeed * Time.deltaTime);
            rigidBody.velocity = transform.forward * speed;
            anim.SetFloat("Blend", 1);

        }
        else
        {
            anim.SetFloat("Blend", 0); 
        }

        void OnCollisionEnter(Collision other)
        {

        }

        void OnCOllisionExit(Collision other)
        {

        }
    }
}
