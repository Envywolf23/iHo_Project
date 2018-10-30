using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class MovementBadBullet : MonoBehaviour {

    public float velocidad;
    float contadorAutoDestruccion;
    public bool enPausa = false;
    public Rigidbody2D rbBotella;
    public bool isAtrapado;
    public string tagSpawner;
    GameObject spawner;

    // Use this for initialization
    void Start () {

        spawner = GameObject.FindGameObjectWithTag(tagSpawner);

        isAtrapado = false;

        contadorAutoDestruccion = 0f;
        rbBotella.AddForce(rbBotella.transform.up * velocidad, ForceMode2D.Impulse);
    }
	
	// Update is called once per frame
	void Update () {

        if (enPausa == true)
        {
            // colliderPropio.enabled = false;
            transform.Rotate(0, 0, 0);

        }

        if (isAtrapado == false)
        {
            transform.Rotate(0, 0, 3f);
        }

        if (transform.position.x >= 25 || transform.position.x <= -25)
        {
            contadorAutoDestruccion += Time.deltaTime;

            if (contadorAutoDestruccion < 5f)
            {
                Destroy(gameObject);
                spawner.GetComponent<SpawnerBadBullet>().canCreate = true;
                
            }

        }

        if (transform.position.y >= 15 || transform.position.y <= -15)
        {
            contadorAutoDestruccion += Time.deltaTime;

            if (contadorAutoDestruccion < 5f)
            {
                Destroy(gameObject);
                spawner.GetComponent<SpawnerBadBullet>().canCreate = true;
            }
        }
    }
}
