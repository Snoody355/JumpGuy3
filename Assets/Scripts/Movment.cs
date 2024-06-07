using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D PlayerRB;

    [SerializeField]
    private Collider2D PlayerColider;

    [SerializeField]
    private LayerMask groundColdier;

    [SerializeField] private bool isGrounded;
    [SerializeField] private bool stoppedJumping;

    [SerializeField]
    private float jumpForce;

    [SerializeField]
    private float JumpTime;

    [SerializeField]
    private float jumpTimeCounter;

    [SerializeField]
    private Animator playerAnimator;

    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundCheckRadius;


    [SerializeField] private Health health;

    // Start is called before the first frame update
    void Start()
    {
        jumpTimeCounter = JumpTime;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
            IsGrounded();
            JumpPlayer();

        










    }

    

        


    public void JumpPlayer()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {

                playerAnimator.SetBool("Jumped", true);
                PlayerRB.velocity = new Vector2(PlayerRB.velocity.x, jumpForce);
                
            }

           
            // transform.Translate(Vector2.up * jumpForce * Time.deltaTime);
            //

            
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            playerAnimator.SetBool("Jumped", false);
        }

        /*if (Input.GetKey(KeyCode.Space) && !stoppedJumping)
        {
            if (jumpTimeCounter > 0)
            {
                PlayerRB.velocity = new Vector2(PlayerRB.velocity.x, jumpForce);
                jumpTimeCounter -= Time.deltaTime;
            }
        } 

        if (Input.GetKeyUp(KeyCode.Space))
        {
            jumpTimeCounter = 0;
            stoppedJumping = true;
        } */
    }

     public void IsGrounded()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundColdier);
        if (isGrounded)
        {
            jumpTimeCounter = JumpTime;
        }
    }

    private void ResetPlayerRotation()
    {
        
    }


}
