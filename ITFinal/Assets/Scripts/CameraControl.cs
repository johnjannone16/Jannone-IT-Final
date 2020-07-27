using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] float m_GroundCheckDistance = 0.1f;
    [Range(1f, 4f)] [SerializeField] float m_GravityMultiplier = 2f;


    private const float Y_ANGLE_MIN = 5.0f;
    private const float Y_ANGLE_MAX = 180.0f;

    public Transform character;
    public float jumpForce = 20.0f;

    private float distance = -10.0f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private float distToGround;
    float m_OrigGroundCheckDistance;
    Rigidbody m_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_OrigGroundCheckDistance = m_GroundCheckDistance;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxis("Mouse X") != null || Input.GetAxis("Mouse Y") != null)
        {
            currentX += Input.GetAxis("Mouse X");
            currentY += Input.GetAxis("Mouse Y");
        }
        currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);

    }

    private void LateUpdate()
    {
        gameObject.transform.position = character.position + Quaternion.Euler(currentY, currentX, 0) * new Vector3(0, 0, distance);
        gameObject.transform.LookAt(character.position);
    }

    void HandleAirborneMovement()
    {
        // apply extra gravity from multiplier:
        Vector3 extraGravityForce = (Physics.gravity * m_GravityMultiplier) - Physics.gravity;
        m_Rigidbody.AddForce(extraGravityForce);

        m_GroundCheckDistance = m_Rigidbody.velocity.y < 0 ? m_OrigGroundCheckDistance : 0.01f;
    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);
    }

}
