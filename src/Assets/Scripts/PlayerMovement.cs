using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public Animator animator;

    public float gravity = 10;
    public float maxHeight = 2;
    public float animationSpeedCoeficient = 1;


    private float actualHeight;
    private bool isJumping;
    private float newY;
    private float initialY;
    private bool yInitialized;
    private Vector3 newPos;
    private GameSettings settings;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        settings = FindObjectOfType<GameSettings>();

        isJumping = false;
        newPos = controller.transform.position;
        actualHeight = 0;
        yInitialized = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (settings.gameOver)
        {
            animator.enabled = false;
            return;
        }
        if (!yInitialized)
        {
            controller.Move(new Vector3(0, (float)-1 * Time.deltaTime, 0));
            if (controller.isGrounded)
            {
                initialY = controller.transform.position.y;
                yInitialized = true;
            }
            return;
        }

        if ((controller.transform.position.y - initialY) < 0)
        {
            newY = initialY;
            actualHeight = 0;
            isJumping = false;
            newPos.y = newY;
            controller.transform.position = newPos;
            animator.SetBool("jump", false);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (controller.isGrounded)
            {
                isJumping = true;
                animator.SetBool("jump", true);
            }
        }

        if (isJumping)
        {
            actualHeight += (Time.deltaTime * gravity)/10;
            newY = initialY + maxHeight * Mathf.Sin(actualHeight * (settings.getSpeed() / 10 ));
            newPos.y = newY;
            controller.transform.position = newPos;
        }
        else
        {
            controller.Move(new Vector3(0, (float) -1* Time.deltaTime, 0));
        }
        animator.speed = (settings.getSpeed()/10) * animationSpeedCoeficient;


    }
}
