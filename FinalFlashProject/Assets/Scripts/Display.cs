using UnityEngine;
using System.Collections;

public class Display : MonoBehaviour, IMessageListener {

	// Use this for initialization
	void Start () {
		MessageMgr.Instance.AddListener(this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnMessage (eMessageID _messageID, GameObject _sender)
	{
		if(_messageID == eMessageID.eScoreBasic)
		{
			CurrentScore.score += 1;
		}
		if(_messageID == eMessageID.eScore)
		{
			CurrentScore.score += 3;
		}
	}
	
	void OnGUI()
	{
		GUI.Label(new Rect(800, 20, 100, 30), "score : "+CurrentScore.score);
		GUI.Label(new Rect(20, 20, 100, 30), "health : "+Player.health);
	}
}
