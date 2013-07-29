using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	private float bulletSpeed;
	private Transform _transform;
	private Vector3 velocity;

	// Use this for initialization
	void Start () {
		bulletSpeed = 6.0f;
		_transform = transform;
		velocity = new Vector3(0, 0, bulletSpeed);		
	}
	
	// Update is called once per frame
	void Update () {
		_transform.Translate(0, 0, velocity.z * Time.deltaTime);		
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag.Equals("Wall"))
			Destroy(gameObject);
	}
}
