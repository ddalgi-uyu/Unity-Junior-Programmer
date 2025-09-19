using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerXC3 : MonoBehaviour
{
    public bool gameOver;
    public AudioClip moneySound;
    public AudioClip explodeSound;
    public AudioClip bounceSound;
    public float floatForce;
    public float bounceForce;
    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;

    private float gravityModifier = 1.5f;
    private Rigidbody playerRb;
    private AudioSource playerAudio;
    private float upperBound = 15f;
    private float lowerBound = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();

        // Apply a small upward force at the start of the game
        playerRb = GetComponent<Rigidbody>();
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);

        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > upperBound)
        {
            transform.position = new Vector3(transform.position.x, upperBound, transform.position.z);
            playerRb.AddForce(Vector3.down * bounceForce);
        }
        else if (transform.position.y <= lowerBound)
        {
            playerAudio.PlayOneShot(bounceSound, 1.0f);
            playerRb.AddForce(Vector3.up * bounceForce);
        }

        // While space is pressed and player is low enough, float up
        if (Input.GetKey(KeyCode.Space) && !gameOver)
        {
            playerRb.AddForce(Vector3.up * floatForce);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Bomb"))
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
        } 

        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Money"))
        {
            fireworksParticle.Play();
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);
        }

    }

}
