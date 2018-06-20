using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public Transform tf;
	public float speed;

    // Use this for initialization
    void Start () {
		tf = GetComponent<Transform> ();
        
	}

    // Update is called once per frame
    void Update()
    {
        Move();
        Destroy(this.gameObject, 2);
    }

    //Tells bullet to move 
    public void Move () {
		tf.position += tf.up * speed* 0.05f;
	}
}