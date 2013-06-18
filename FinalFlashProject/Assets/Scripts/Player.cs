using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	private float speed;

	// Use this for initialization
	void Start () {
		speed = 5.0f;
	}
	
	// Update is called once per frame
	void Update () {
		
		//limite de deplacement
		//si le joueur dépasse une limite, on le remet a la limite +/- sa taille/2 (le point du cube se trouve au centre)
		if(transform.position.x < -7.56f + (transform.localScale.x/2))
			transform.position = new Vector3(-7.56f + (transform.localScale.x/2), transform.position.y, transform.position.z);
		if(transform.position.x > 7.54f - (transform.localScale.x/2))
			transform.position = new Vector3(7.54f - (transform.localScale.x/2), transform.position.y, transform.position.z);
		
		if(transform.position.y < -4.04f + (transform.localScale.y/2))
			transform.position = new Vector3(transform.position.x, -4.04f + (transform.localScale.y/2), transform.position.z);
		if(transform.position.y > 6.06f - (transform.localScale.y/2))
			transform.position = new Vector3(transform.position.x, 6.06f - (transform.localScale.y/2), transform.position.z);
		
		//deplacement du joueur
		float translateX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		float translateY = Input.GetAxis("Vertical") * speed * Time.deltaTime;
		
		transform.Translate(translateX, translateY, 0);
	}
}
