using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSpawn : MonoBehaviour
{

    public Transform target1, target2;
    public Transform current;
    public float velocidad;
    public bool enPausa = false;


    // Use this for initialization
    void Start()
    {
        current = target1;
    }

    // Update is called once per frame
    void Update()
    {
        if (enPausa == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, current.position, velocidad); //Moverse hacia el target
        }

        float distance = Vector3.Distance(transform.position, current.position); //La distancia a la que esta de su objetivo


        if (distance < 2f) //Si ya es hora de cambiar target
        {
            if (current == target1)
            {
                current = target2;
            }
            else if (current == target2)
            {
                current = target1;
            }
        }
    }
}
