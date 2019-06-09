using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MobileGaming
{
    public class PlayerController : MonoBehaviour
    {
        public bool isGrounded;
        public Rigidbody rigid;
        public float groundRayDitance = 0.5f;
        public float jumpHeight = 10f;
        public int jumpCount = 0;
        public float sideRayDistance = 0.5f;
        public float moveSpeed = 3;
        public bool isGameOver;
        public GameObject keepPlayingMenu;

        private Vector3 spawnPoint;
        private Ray Groundray;

        // Use this for initialization
        void Start()
        {
            rigid = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            PushRight();  // Calling these in Update so they constantly happen
            Movement();   // Calling these in Update so they constantly happen
        }

        void PushRight()
        {
            rigid.velocity = new Vector3(1 * moveSpeed, rigid.velocity.y, 0 );

            //rigid.AddForce(transform.right * moveSpeed, ForceMode.);
        }

        void Movement()
        {
            Ray GroundRay = new Ray(transform.position, -transform.up); // setting a ray to go down
            RaycastHit hit; 
            if (Physics.Raycast(GroundRay, out hit, groundRayDitance)) // calling it when a ray hits
            {
                isGrounded = true;
                jumpCount = 0;
            }
            if (Input.GetMouseButtonDown(0) && jumpCount < 2) // this is what allows the double jump to happen
            {
                isGrounded = false;
                Jump();
                jumpCount++;
            }

            CheckStopped();
        }

        void CheckStopped() // this sends a ray to the side to check if we have collided with a surface
        {
            //if (rigid.velocity.x == 0)
            //{
            //    print("Stopped");
            //}

            Ray SideRay = new Ray(transform.position, transform.right);
            RaycastHit hit;
            if (Physics.Raycast(SideRay, out hit, sideRayDistance))
            {
                GameOver();
            }
        }
        void Jump()
        {
            rigid.velocity = new Vector2(rigid.velocity.x, jumpHeight); // adds a small force Upwards timsed by jumpheight
        }

        void GameOver()
        {
            keepPlayingMenu.SetActive(true);
        }
    }
}
