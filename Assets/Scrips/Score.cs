using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour {
    public int score;
    public TimeRecord timeRecord;
    [SerializeField]
    TextMeshProUGUI text;

	// Use this for initialization
	void Start () {

        score = 0;

    }
	
	
    
    // Update is called once per frame
	void Update () {

        text.text = "Puntos: " + score + "/" + timeRecord.MetaScore;

        if (score < timeRecord.MetaScore)
        {
            text.color = new Color(255f, 0f, 0f, 255f);
        }
        else
        {
            text.color = new Color(0f, 255f, 0f, 255f);
        }
	}
}
