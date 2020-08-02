using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class airDash : MonoBehaviour
{
    [SerializeField] float m_GroundCheckDistance = 0.1f;


    Animator anim;
    public GameObject player;
    private bool grounded;
    Vector3 m_GroundNormal;
    public static bool m_IsGrounded;
    public float distance;
    public static bool manaCost;


    public gameController mana;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
        grounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        CheckGroundStatus();
        airDashForward();
    }

    private void airDashForward()
    {
        if(m_IsGrounded == false && Input.GetKey(KeyCode.F) && fireflyChangeMat.abilityNum == 1 && mana.currentMana >= 20)
        {
            player.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * distance);
            anim.SetBool("airDash", true);
            manaCost = true;
        }
        else
        {
            anim.SetBool("airDash", false);
            
        }
        if (m_IsGrounded == false && Input.GetKeyDown(KeyCode.F) && fireflyChangeMat.abilityNum == 1 && mana.currentMana >= 20)
        {
            manaCost = true;
            Debug.Log("using mana");
        }
        else
        {
            manaCost = false;
        }

    }

    void CheckGroundStatus()
    {
        RaycastHit hitInfo;
#if UNITY_EDITOR
        // helper to visualise the ground check ray in the scene view
        Debug.DrawLine(transform.position + (Vector3.up * 0.1f), transform.position + (Vector3.up * 0.1f) + (Vector3.down * m_GroundCheckDistance));
#endif
        // 0.1f is a small offset to start the ray from inside the character
        // it is also good to note that the transform position in the sample assets is at the base of the character
        if (Physics.Raycast(transform.position + (Vector3.up * 0.1f), Vector3.down, out hitInfo, m_GroundCheckDistance))
        {
            m_GroundNormal = hitInfo.normal;
            m_IsGrounded = true;
            //anim.applyRootMotion = true;
            Debug.Log("on ground");
        }
        else
        {
            m_IsGrounded = false;
            m_GroundNormal = Vector3.up;
            Debug.Log("in air");
            //anim.applyRootMotion = false;
        }
    }

    

}
