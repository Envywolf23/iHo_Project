using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class MovementFoxBottles : MonoBehaviour {

    public bool esDerecho;
    public float valorFuerza;
    public Rigidbody2D rbBotella;
    public string tagSpawner;
    GameObject spawner;

    float contadorAutoDestruccion;

	// Use this for initialization
	void Start () {

        spawner = GameObject.FindGameObjectWithTag(tagSpawner);

        Vector2 direccionSalida;

        if (esDerecho)
        {
            direccionSalida = new Vector2(-8F, 7.5F);
            rbBotella.AddForce(direccionSalida, ForceMode2D.Impulse);
        }
        else if(esDerecho == false)
        {
            direccionSalida = new Vector2(8F, 7.5F);
            rbBotella.AddForce(direccionSalida, ForceMode2D.Impulse);
        }


        
        
	}
	
	// Update is called once per frame
	void Update () {

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
