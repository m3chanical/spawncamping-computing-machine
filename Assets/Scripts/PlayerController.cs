using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void FixedUpdate() {
		if(Input.GetKeyDown(KeyCode.A)){
			//GetComponent<Rigidbody2D>().AddForce(Vector2.right * speed * Time.deltaTime);
			transform.position += transform.right * Time.deltaTime; 	
		}
		if(Input.GetKeyDown (KeyCode.Space)){
			GetComponent<Rigidbody2D>().AddForce (Vector2.up * speed * Time.deltaTime);
		}
	}
}
