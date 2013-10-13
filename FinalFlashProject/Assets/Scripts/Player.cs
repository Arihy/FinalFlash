using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	private float speed;
	public static int health;
	private Transform _transform;
	
	public Transform primaryWeapon;
	private Transform pWeapon;

	// Use this for initialization
	void Start () {
		speed = 5.0f;
		health = 3;
		_transform = transform;
		pWeapon = Instantiate(primaryWeapon, _transform.position, Quaternion.identity) as Transform;
		pWeapon.parent = _transform;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(health <= 0)
			MessageMgr.Instance.NotifyObservers(eMessageID.eLoose, this.gameObject);
		
		//limite de deplacement
		//si le joueur dépasse une limite, on le remet a la limite +/- sa taille/2 (le point du cube se trouve au centre)
		if(_transform.position.x < -7.56f + (_transform.localScale.x/2))
			_transform.position = new Vector3(-7.56f + (_transform.localScale.x/2), _transform.position.y, _transform.position.z);
		if(_transform.position.x > 7.54f - (_transform.localScale.x/2))
			_transform.position = new Vector3(7.54f - (_transform.localScale.x/2), _transform.position.y, _transform.position.z);
		
		if(_transform.position.z < -4.04f + (_transform.localScale.z/2))
			_transform.position = new Vector3(_transform.position.x, _transform.position.y, -4.04f + (_transform.localScale.z/2));
		if(_transform.position.z > 6.06f - (_transform.localScale.z/2))
			_transform.position = new Vector3(_transform.position.x, _transform.position.y, 6.06f - (_transform.localScale.z/2));
		
		//deplacement du joueur
		float translateX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		float translateY = Input.GetAxis("Vertical") * speed * Time.deltaTime;
		
		_transform.Translate(translateX, 0, translateY);
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag.Equals("Enemy"))
			health--;
	}
	
	public int getHealth()
	{
		return health;
	}
}
