using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;
    

    private Animator playerAnim;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;

    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playerAudio;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {   //detects if player is on ground and is not game over then gets the jump input if both are true
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpSound, 1.0f);

        }

    }
    //sets isOnGround to true if in contact with the ground
    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;

        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticle.Play();
        }
        //else if colides with obstacle
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
            
            gameOver = true;
            Debug.Log("Game Over!!!");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType", 1);
            explosionParticle.Play();
            dirtParticle.Stop();
            playerAudio.PlayOneShot(crashSound, 1.0f);

         }
        //stops dirt animation when laying on the ground
        if(gameOver == true)
        {
            dirtParticle.Stop();
        }
    }   
}
