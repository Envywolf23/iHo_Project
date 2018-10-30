using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementFox : MonoBehaviour {
 
   public Transform target1, target2, target3, target4, myself;  //Los objetivos a los que se mueve el Zorro
     
    public Transform current;  //Objetivo Atual hacia el cual se mueve
    public float velocidad; //Para medir el momento en el que debe cambiar de target
    public bool EnPausa = false;
   
    // Use this for initialization
    void Start () {
        current = target1; //Iniciacion al target1
        myself = GetComponent<Transform>();
        
      
	}
	
	// Update is called once per frame
	void Update () {

        if(EnPausa == false)
        {
          transform.position = Vector3.MoveTowards(transform.position, current.position, velocidad); //Moverse hacia el target
        }
        
       // Debug.Log("Destino " + current);       

        float distance = Vector3.Distance(transform.position, current.position); //La distancia a la que esta de su objetivo

       if (distance < 2f) //Si ya es hora de cambiar target
        {
            if (current == target1)
            {

                current = target2;
                Debug.Log("Cambio de target: " + current);

               


            }
            else if (current == target2)
            {

                current = target3;
                Debug.Log("Cambio de target: " + current);



            }
           else if (current == target3)
            {

                current = target4;
                Debug.Log("Cambio de target: " + current);



            }

          else  if (current == target4)
            {

                current = target1;
                Debug.Log("Cambio de target: " + current);



            }

        }


	}
}
