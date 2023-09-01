using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject : MonoBehaviour {

    // Referencia al Audio Source
    public AudioSource audioSource;

    // Sonido de daño
    public AudioClip hitSFX;

    private void OnCollisionEnter2D(Collision2D collision) {
        // Si el personaje se colisiona con el objeto,
        // el personaje desaparece
        if (collision.transform.CompareTag("Player")) {
            Debug.Log("Player Damaged");

            if (audioSource.isPlaying) {
                return;
            }

            // Ejecuta sonido de daño
            audioSource.PlayOneShot(hitSFX);

            Destroy(collision.gameObject);
        }
    }
}
