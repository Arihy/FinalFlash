using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {
	private float fireRate;
	private float nextFire;
	private Transform _transform;
	public Transform bulletPrefab;
	public Transform pointeur;
	private Vector3 lookTarget;

	// Use this for initialization
	void Start () {
		_transform = transform;
		fireRate = 0.3f;
		nextFire = 0.0f;
		lookTarget = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
		
		Ray ray = Camera.mainCamera.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if(Physics.Raycast(ray, out hit))
			lookTarget = hit.point;
		_transform.LookAt(lookTarget);
		
		
		if(Input.GetMouseButton(0))
		{
			if(Time.time > nextFire)
			{
				nextFire = Time.time + fireRate;
				Transform bullet = Instantiate(bulletPrefab, _transform.position, _transform.rotation) as Transform;
			}
		}
	}
}
