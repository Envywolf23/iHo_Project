using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public GameObject creditos;

    public void CambioCreditos()
    {
        creditos.SetActive(true);
    }

    public void CerrarCreditos()
    {
        creditos.SetActive(false);
    }

}
