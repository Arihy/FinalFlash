using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	
	private Transform _transform;
	protected Vector3 velocity;
	private Transform player;

	// Use this for initialization
	//virtual permet de pouvoir faire des surcharges
	public virtual void Start () {
		_transform = transform;
		velocity = new Vector3(Random.Range(1.0f, 3.0f), 0, Random.Range(1.0f, 3.0f));
		player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	public virtual void Update () {
		_transform.Translate(velocity.x * Time.deltaTime, 0, velocity.z * Time.deltaTime);
		_transform.LookAt(player);
	}
	
	//tous les ennemis sont detruit quand ils dépassent la limite
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag.Equals("EnemyWall"))
			Destroy(gameObject);
		if(other.gameObject.tag.Equals("Bullet"))
			Destroy(gameObject);
		if(other.gameObject.tag.Equals("Player"))
			Destroy(gameObject);
	}
}
