using UnityEngine;
using System.Collections;

public class SpownManag : MonoBehaviour {
	public Transform enemyPrefab;
	
	private float spownRate;
	private float nextSpown;

	// Use this for initialization
	void Start () {
		spownRate = 2.5f;
		nextSpown = 2.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > nextSpown)
		{
			nextSpown = Time.time + spownRate;
			Instantiate(enemyPrefab, new Vector3(Random.Range(-8.0f, 8.0f), 0, -5.0f), Quaternion.identity);
			Instantiate(enemyPrefab, new Vector3(-8.0f, 0, Random.Range(-6.0f, 8.0f)), Quaternion.identity);
			Instantiate(enemyPrefab, new Vector3(Random.Range(-8.0f, 8.0f), 0, 5.0f), Quaternion.identity);
			Instantiate(enemyPrefab, new Vector3(8.0f, 0, Random.Range(-6.0f, 8.0f)), Quaternion.identity);
		}
	}
}
