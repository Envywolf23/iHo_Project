using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Caneca : MonoBehaviour
{

    public Score puntaje;
    public string basuraCorrecta;
    public SpawnerBadBullet spawner;
    public AudioReproductor reproductor;
    ObserverFallas fallas;
    public GameObject particula1;




    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == basuraCorrecta)
        {
            puntaje.score += 1;

            Destroy(collision.gameObject);

            spawner.canCreate = true;

            Vibration.Vibrate(60);

            Debug.Log("colision");

            reproductor.ReproducirBueno();

            Vector3 v3 = new Vector3(transform.position.x, transform.position.y + 4, transform.position.z);

            Instantiate(particula1, v3, Quaternion.identity);
        }
    }
}
