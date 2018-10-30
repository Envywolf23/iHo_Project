using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialController : MonoBehaviour {

    public GameObject TutorialHud, NormalHud;
    public LoadingScreenController loadingSC;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void IniciarTutorial()
    {
        TutorialHud.SetActive(true);
        NormalHud.SetActive(false);
    }

    public void FinalizarTutorial()
    {
        TutorialHud.SetActive(false);
        loadingSC.LoadScreen(1);
    }
}
