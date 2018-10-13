using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public int speed = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		// update player position based on input
		Vector3 position = transform.position;
		position.x += moveHorizontal * speed * Time.deltaTime;
		position.z += moveVertical * speed * Time.deltaTime;
		transform.position = position;
	}
}
