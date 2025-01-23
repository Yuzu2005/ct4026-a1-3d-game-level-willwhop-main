using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
    [SerializeField] Transform groundCheckTransform;
    [Header("Movement")]
    public float moveSpeed;

    public float groundDrag;

    [Header("Ground Check")]
    public float playerHeight;
    bool grounded;
    public LayerMask whatIsGround;

    [Header("Keybinds")]
    //assigns the space key for the jump
    public KeyCode jumpKey = KeyCode.Space;

    public float jumpForce;
    public float jumpCooldown;
    public float airMultiplier;
    //bool readyToJump;

    public Transform oriantion;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    Rigidbody rb;

    //will assign the object with a rigidbody and freeze its rotation
    private void Start() {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void FixedUpdate() {
        MovePLayer();
    }

    //private void OnDrawGizmos() {
      //  Gizmos.DrawSphere(groundCheckTransform.position, .3f);
    //}

    private void Update() {
        //checks to see if there is ground underneath the sphere
        grounded = Physics.CheckSphere(groundCheckTransform.position, .3F, whatIsGround);
        Debug.Log(grounded);
        SpeedControl();
        MyInput();

        //if grounded add drag
        if (grounded) {
            rb.drag = groundDrag;
        }
        // else theres no drag
        else {
            rb.drag = 0;
        }
    }

    
    private void MyInput() {
        //checks to see which keys the player presses and decides whether they want to move horizontally or vertically 
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        //if the character is grounded and has pressed the space key then the jump function is called
        if (Input.GetKey(jumpKey) && grounded) {
            //readyToJump = false;
            Jump();
            Debug.Log("jumping");

            //resets jump so the character controller can continusly jump after hiting the ground
            //Invoke(nameof(ResetJump), jumpCooldown);

        }
    }

    private void MovePLayer() {
        //calculates the direction the player will move
        moveDirection = oriantion.forward * verticalInput + oriantion.right * horizontalInput;

        //if players grounded then it will add force to the rigidbody
        if (grounded) {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);

        }

        //if not grounded it will add a diffrent force with the airMultiplier
        else if (!grounded) {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f * airMultiplier, ForceMode.Force);
        }

    }

    private void SpeedControl() {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        //if the the magnitude is greater than the set speed then it will limit it to the normal speed
        if (flatVel.magnitude > moveSpeed) {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }

    private void Jump() {
        //velocity is set to 0 so the jump hight will always be the same
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        //adds an upwards force to the rigidbody
        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        Debug.Log("jumping by " + jumpForce);
    }

   // private void ResetJump() {
     //   readyToJump = true;
    //}
}
