using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioReproductor : MonoBehaviour
{

    public AudioSource goodFX, badFX;

    public void ReproducirBueno()
    {
        goodFX.Play();
    }

    public void ReproducirMalo()
    {
        badFX.Play();
    }
}
