using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isGrounded;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    public Rigidbody rigid;
    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigid.velocity = new Vector3(3, rigid.velocity.y);

        if (Input.GetMouseButtonDown(0))
        {
            rigid.velocity = new Vector2(rigid.velocity.x, 3);
        }

    }
}
