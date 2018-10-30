using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Transform transform;
    float mY;  //Variable para vector 3 en Y
    int[] senYo = { 1, -1 };  //Para saber el sentido del movimiento en Y
    int randomy; //Variable de random para el sen
    float seny;  //Sentido de y
    float magy; //Magnitud en Y


    float mX;  //Variable para vector 3 en X
    int[] senXo = { 1, -1 };  //Para saber el sentido del movimiento en X
    int randomx; //Variable de random para el sen
    float senx;  //Sentido de X
    float magx = 8f; //Magn

    float contador;


    // Use this for initialization
    void Start()
    {
        transform = GetComponent<Transform>();
        contador = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dirx = new Vector3(mX, 0, 0); //Vector Movimiento X

        //Informacion Movimiento en x
        Vector3 diry = new Vector3(0, mY, 0); //El vector de direccion en Y


        Vector3 velx = dirx * magx * senx; //Velocidad en X
        Vector3 vely = diry * magy * seny; //Velocidad en Y



        Vector3 desplazamiento = (velx + vely) * Time.deltaTime; //El desplazamiento total

        transform.position += desplazamiento;  //Actualizacion de la posicion

        if (transform.position.x >= 25 || transform.position.x <= -25)
        { 
            contador += Time.deltaTime;

            if(contador < 5f)
            {
                Destroy(gameObject);
            }

        }

        if (transform.position.y >= 15 || transform.position.y <= -15)
        {
            contador += Time.deltaTime;

            if (contador < 5f)
            {
                Destroy(gameObject);
            }
        }





    }

    public void Target1()
    {
        mX = 1;
        senx = -1;
        magx = 8f;


        mY = Random.Range(0f, 1f); //Se inicia el random
        randomy = Random.Range(0, 2); //Se escoge uno de los 2 nums del arreglo
        seny = senYo[randomy]; //Se introduce el random para obtener el num del arreglo
        magy = Random.Range(2, 8); //El rango de las magnitudes

        Debug.Log("Se le dio el target 1 movimiento");


    }

    public void Target2()
    {
        randomy = Random.Range(0, 2); //Se escoge uno de los 2 nums del arreglo
        senx = senXo[randomy]; //Se introduce el random para obtener el num del arreglo
        magx = Random.Range(2, 8);
        mX = Random.Range(0f, 1f);

        mY = 1;
        seny = -1;
        magy = 8f;
        Debug.Log("Se le dio el target 2 movimiento");

    }

    public void Target3()
    {
        mX = 1;
        senx = 1;
        magx = 8f;

        mY = Random.Range(0f, 1f); //Se inicia el random
        randomy = Random.Range(0, 2); //Se escoge uno de los 2 nums del arreglo
        seny = senYo[randomy]; //Se introduce el random para obtener el num del arreglo
        magy = Random.Range(2, 8); //El rango de las magnitudes
        Debug.Log("Se le dio el target 3 movimiento");
    }

    public void Target4()
    {
        randomy = Random.Range(0, 2); //Se escoge uno de los 2 nums del arreglo
        senx = senXo[randomy]; //Se introduce el random para obtener el num del arreglo
        magx = Random.Range(2, 8);
        mX = Random.Range(0f, 1f);

        mY = 1;
        seny = 1;
        magy = 8f;
        Debug.Log("Se le dio el target 4 movimiento");

    }

    

}

