using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {
	private Transform tf;
    public Vector2 playerStartPosition;
    public float speed;
	public float turnSpeed; 



	void Start () {
		tf = GetComponent<Transform>();
        transform.position = playerStartPosition;

    }

	void Update ()
	{
		if (Input.GetKey (KeyCode.UpArrow)) {
			tf.Translate(Vector3.up * 0.05f); //up
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			tf.Translate (Vector3.down * 0.05f); //down
        }
		if (Input.GetKey (KeyCode.LeftArrow)) {
			tf.Rotate (0, 0, turnSpeed); //rotate left
        }
		if (Input.GetKey (KeyCode.RightArrow )){
			tf.Rotate (0, 0, -turnSpeed); //rotate right 
        }
		//if (Input.GetKey (KeyCode.Space))
			//tf.position = Vector3.zero;
	}

    // This function will remove 1 life from GameManager and destroy all spawned enemies, will reset everything 
    void OnDestroy()
    {
        GameManager.instance.playerLives -= 1;
        Destroy(GameManager.instance.enemiesSpawned[0]);
        Destroy(GameManager.instance.enemiesSpawned[1]);
        Destroy(GameManager.instance.enemiesSpawned[2]);
    }
}  