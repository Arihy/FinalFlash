using UnityEngine;
using System.Collections;

public class GameOverRestart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown()
	{
		Application.LoadLevel("level1");
		CurrentScore.score = 0;
	}
	
	void OnGUI()
	{
		GUI.Label(new Rect(400, 400, 100, 30), "Votre score : "+CurrentScore.score);
	}
}
