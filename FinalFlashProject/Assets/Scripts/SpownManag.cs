using UnityEngine;
using System.Collections;

public class SpownManag : MonoBehaviour {
	public Transform enemyPrefab;
	
	private float spownRate;
	private float nextSpown1;
	private float nextSpown2;

	// Use this for initialization
	void Start () {
		spownRate = 4.5f;
		nextSpown1 = 2.0f;
		nextSpown2 = 2.5f;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > nextSpown1)
		{
			Instantiate(enemyPrefab, new Vector3(Random.Range(-8.0f, 8.0f), 0, -5.0f), Quaternion.identity);
			Instantiate(enemyPrefab, new Vector3(-8.0f, 0, Random.Range(-6.0f, 8.0f)), Quaternion.identity);
			nextSpown1 = Time.time + spownRate;
		}
		if(Time.time > nextSpown2)
		{
			Instantiate(enemyPrefab, new Vector3(Random.Range(-8.0f, 8.0f), 0, 5.0f), Quaternion.identity);
			Instantiate(enemyPrefab, new Vector3(8.0f, 0, Random.Range(-6.0f, 8.0f)), Quaternion.identity);
			nextSpown2 = Time.time + spownRate + 0.3f;
		}
	}
}
