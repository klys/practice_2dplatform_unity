using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActionController : MonoBehaviour
{

    private Rigidbody2D playerPhysics;

    // Start is called before the first frame update
    [Header("Physic Variables")]
    [SerializeField] public float jumpForce = 7f;
    [SerializeField] public float movementForce = 7f;
    
    void Start()
    {
        playerPhysics = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalDirection = Input.GetAxis("Horizontal"); // there also exists GetAxisRaw
        if (horizontalDirection != 0)
        {
            playerPhysics.velocity = new Vector3(horizontalDirection * movementForce, playerPhysics.velocity.y, 0);
        }


        //if (Input.GetKey("space"))
        if (Input.GetButtonDown("Jump"))
        {
            playerPhysics.velocity = new Vector3(0, jumpForce, 0);
        }
    }
}
