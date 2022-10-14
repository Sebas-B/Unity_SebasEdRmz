using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public bool gameOver;

    public float floatForce;
    private float gravityModifier = 1.5f;
    private Rigidbody playerRb;

    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;

    private AudioSource playerAudio;
    public AudioClip moneySound;
    public AudioClip explodeSound;

    public bool isLowEnough;

    public AudioClip bounceSound;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();

        // Aplica un pequño empujon al inicio del juego
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);

    }

    void Update()
    {
        // Mientra es precionado espacio y la altura sea lo suficientmente
        // baja se elevara el globo
        if (Input.GetKey(KeyCode.Space) && isLowEnough && !gameOver)
        {
            playerRb.AddForce(Vector3.up * floatForce);
        }

        if (transform.position.y > 12){
            isLowEnough = false;
        } else {
            isLowEnough = true;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // Si el jugador choca con una bomba, explotara y pondra gameOver en verdadero
        if (other.gameObject.CompareTag("Bomb"))
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
        } 

        // Si el jugaor toma el dinero saldran fuegos artificiales
        else if (other.gameObject.CompareTag("Money"))
        {
            fireworksParticle.Play();
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);

        }
        else if(other.gameObject.CompareTag("Ground"))
        {
            playerRb.AddForce(Vector3.up * 10, ForceMode.Impulse);
            playerAudio.PlayOneShot(bounceSound, 1.5f);
        }

    }

}
