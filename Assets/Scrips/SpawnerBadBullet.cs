using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBadBullet : MonoBehaviour {

    Transform transform;
    public GameObject[] ObjClonar;
    public float minValCreate, maxValCreate;
    bool basuraExiste;

    public bool canCreate; //Si puedes crear o no Objetos
    float timeCreate; //Tiempo en el cual se crean, el cual puede variar
    float time = 0; //Contador del tiempo
    Vector3 posicion; //Vector desde donde aparecera el Objeto
    MovementBadBullet bulletMove;

    // Use this for initialization
    void Start () {
        transform = GetComponent<Transform>(); //Transform propio
        canCreate = false;  //Puede crear valor inicial
        timeCreate = 1f; //Tiempo para crear valor inicial
        canCreate = true;

        // ObjClonar = GameObject.FindGameObjectWithTag("Bullet");//Busca Objeto a clonar
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posicion = transform.position;

        if (canCreate == true) //Es posile rear el Objeto?
        {
           

                GameObject clon = Instantiate(ObjClonar[Random.Range(0, ObjClonar.Length)], posicion, Quaternion.identity);
                Renderer clonRedner = clon.GetComponent<Renderer>();
                Rigidbody clonBody = clon.GetComponent<Rigidbody>();
                bulletMove = clon.GetComponent<MovementBadBullet>(); //Tomar el scrip de movimiento para la botella

                canCreate = false; //Desactivar el Create

                
            
        }

        

       /* time += Time.deltaTime;  //Conteo del tiempo

        if (time >= timeCreate) //Ya es tiempo de crear?
        {
            time = 0; //Reiniciar el tiempo
            timeCreate = Random.Range(minValCreate, maxValCreate); //Escoger otro tiempo
            canCreate = true; //Re-Activar el Create
        }

       */
    }
}
