using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActionController : MonoBehaviour
{

    private Rigidbody2D playerPhysics;
    private SpriteRenderer spriteRenderer;
    private Animator playerAnimator;

    // Start is called before the first frame update
    [Header("Physic Variables")]
    [SerializeField] public float jumpForce = 7f;
    [SerializeField] public float movementForce = 7f;
    
    void Start()
    {
        playerPhysics = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalDirection = Input.GetAxis("Horizontal"); // there also exists GetAxisRaw
        if (horizontalDirection != 0)
        {
            playerPhysics.velocity = new Vector3(horizontalDirection * movementForce, playerPhysics.velocity.y, 0);

            playerAnimator.SetBool("Running", true);
            if (horizontalDirection < 0f)
            {
                spriteRenderer.flipX = true;
            } else
            {
                spriteRenderer.flipX = false;
            }
        } else
        {
            playerAnimator.SetBool("Running", false);
        }


        //if (Input.GetKey("space"))
        if (Input.GetButtonDown("Jump"))
        {
            playerPhysics.velocity = new Vector3(0, jumpForce, 0);
        }
    }
}
