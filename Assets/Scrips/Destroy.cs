using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    AudioReproductor reproductorAudio;

    [SerializeField]
    GameObject particula1, particula2;
   
    MenuPause Pausa;
    public Collider2D Collider2D;

    int tiempo_destruccion;
    
    Score puntos;

    // Use this for initialization
    void Start()
    {
        puntos = GameObject.FindObjectOfType<Score>();
        Pausa = GameObject.FindObjectOfType<MenuPause>();
        reproductorAudio = GameObject.FindObjectOfType<AudioReproductor>();

    }

    private void Update()
    {
        if (Pausa.GameIsPaused == true)
        {
            Collider2D.enabled = false;
        }
        else
        {
            Collider2D.enabled = true;
        }
    }

    private void OnMouseDown()
    {
        if (gameObject.CompareTag("Bullet"))
        {
            puntos.score += 1;
            Debug.Log("Objeto Destruido");
            Instantiate(particula1, transform.position, Quaternion.identity);
            Vibration.Vibrate(60);
            Destroy(gameObject);

            reproductorAudio.ReproducirBueno();
            
            
        }
        if (gameObject.CompareTag("BadBullet"))
        {
            puntos.score -= 2;
            Debug.Log("Objeto Destruido");
            Instantiate(particula2, transform.position, Quaternion.identity);
            Vibration.Vibrate(60);
            Destroy(gameObject);

            reproductorAudio.ReproducirMalo();
            
        }

    }

    /* private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
       
        if (collision.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        */
}



