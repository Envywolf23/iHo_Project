using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour {

    public static Musica musica;
    public AudioSource musicaFondo;



	// Use this for initialization
	void Start () {
        if (musica == null)
        {
            musica = this;
            DontDestroyOnLoad(musicaFondo);
        }
        else
        {
            Destroy(gameObject);
        }
        musicaFondo.Play();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    
}
