using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour 
{
	public GameObject bulletPrefab;
	public Transform shootPoint;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Instantiate (bulletPrefab, shootPoint.position, shootPoint.rotation);
		}
	}
}
