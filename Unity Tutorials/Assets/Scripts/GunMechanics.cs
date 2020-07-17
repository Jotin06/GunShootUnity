using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMechanics : MonoBehaviour
{
	public Transform Bullet;
	public Transform BulletHolder;
	public float BulletSpeed;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButton(0))
		{
			Transform BulletTrans = Instantiate(Bullet, BulletHolder.position, BulletHolder.rotation);
			Rigidbody BulletRB = BulletTrans.GetComponent<Rigidbody>();
			BulletRB.AddRelativeForce(Vector3.forward * BulletSpeed);
		}

	}
}
