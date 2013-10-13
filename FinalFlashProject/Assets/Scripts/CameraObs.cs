using UnityEngine;
using System.Collections;

public enum eEtatID
{
	eWin,
	eLoose
}

public class CameraObs : MonoBehaviour, IMessageListener {
	private eEtatID etat;

	// Use this for initialization
	void Start () {
		MessageMgr.Instance.AddListener(this);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void OnMessage (eMessageID _messageID, GameObject _sender)
	{
		if(_messageID == eMessageID.eWin)
		{
			etat = eEtatID.eWin;
		}
		if(_messageID == eMessageID.eLoose)
		{
			etat = eEtatID.eLoose;
		}
	}
	
	void OnGUI()
	{
		switch(etat)
		{
			case eEtatID.eWin:
				break;
			case eEtatID.eLoose:
				//GUI.Box(new Rect((Screen.width/2) - 200, (Screen.height/2) - 50, 400, 100), "Fail !");
				Application.LoadLevel("gameOver");
				break;
			default:
				break;
		}
	}
}
