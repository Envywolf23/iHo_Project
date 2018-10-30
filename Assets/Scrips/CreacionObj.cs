using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreacionObj : MonoBehaviour
{
    Transform transform;
    GameObject objClonar;
    GameObject objFox;
   /* public bool Alternante;
    public bool Buena;
    float tiempo_cambio;
    float limite_cambio;
    */
    bool canCreate; //Si puedes crear o no Objetos
    float timeCreate; //Tiempo en el cual se crean, el cual puede variar
    float time = 0; //Contador del tiempo
    Vector3 posicion; //Vector desde donde aparecera el Objeto
    MovementFox targetFox;
    Movement bulletMove;

    // Use this for initialization
    void Start()
    {
        transform = GetComponent<Transform>(); //Transform propio
        canCreate = false;  //Puede crear valor inicial
        timeCreate = 1f; //Tiempo para crear valor inicial
        objFox = GameObject.Find("Fox"); //Buscar el objeto Fox para llevar de cuenta sus targets

        targetFox = objFox.GetComponent<MovementFox>();
        objClonar = GameObject.Find("Bullet");//Busca Objeto a clonar
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posicion = transform.position;

        if (canCreate == true) //Es posile rear el Objeto?
        {

            GameObject clon = Instantiate(objClonar, posicion, Quaternion.identity);
            Renderer clonRedner = clon.GetComponent<Renderer>();
            Rigidbody clonBody = clon.GetComponent<Rigidbody>();
            bulletMove = clon.GetComponent<Movement>(); //Tomar el scrip de movimiento para la botella

            canCreate = false; //Desactivar el Create

            if (targetFox.current == targetFox.target1)
            {
                bulletMove.Target1();
            }
            else if (targetFox.current == targetFox.target2)
            {
                bulletMove.Target2();
            }
            else if (targetFox.current == targetFox.target3)
            {
                bulletMove.Target3();
            }
            else if (targetFox.current == targetFox.target4)
            {
                bulletMove.Target4();
            }

        }
        time += Time.deltaTime;  //Conteo del tiempo

        if (time >= timeCreate) //Ya es tiempo de crear?
        {
            time = 0; //Reiniciar el tiempo
            timeCreate = Random.Range(0f, 1f); //Escoger otro tiempo

            canCreate = true; //Re-Activar el Create
        }
    }
}
