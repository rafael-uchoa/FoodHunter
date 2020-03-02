using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Movement
    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    // Buttons
    public int life = 3;
    public bool alive = true;
    public GameObject buttonRestart;
    public GameObject buttonNextLevel;

    // Audio
    public AudioSource playAudio;
    public AudioClip Point;
    public AudioClip Damage;
    public AudioClip LifePickup;
    public AudioClip Death;

    void Start()
    {
        Time.timeScale = 1;
        alive = true;
        Life.lifeAmount = 3;
        playAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

        // Life = 0
        if (Life.lifeAmount <= 0)
        {
            alive = false;
        }

        // Activate Restart Button
        if (alive == false)
        {
            DestroyObject(this.gameObject);
            Time.timeScale = 0;
            buttonRestart.SetActive(true);
        }

        // Activate Next Level Button
        if (Score.scoreAmount >= 250)
        {
            Time.timeScale = 0;
            buttonNextLevel.SetActive(true);
        }

    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }
    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }

    void FixedUpdate()
    {
        // Move Character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    // Item Collision
    private void OnTriggerEnter2D(Collider2D collision2d)
    {
        switch(collision2d.tag)
        {
            case "Point":
                DestroyObject(collision2d.gameObject);
                Score.scoreAmount += 25;
                playAudio.clip = Point;
                playAudio.Play();
                break;
            case "Damage":
                DestroyObject(collision2d.gameObject);
                Life.lifeAmount -= 1;
                playAudio.clip = Damage;
                playAudio.Play();
                break;
            case "Life":
                DestroyObject(collision2d.gameObject);
                Life.lifeAmount += 1;
                playAudio.clip = LifePickup;
                playAudio.Play();
                break;
        }
    }
}