using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	Animator playerAnimator;
	
	void Start () {
		playerAnimator = GetComponent<Animator>();
	}
	
	void Update () {
		float input_x = Input.GetAxisRaw("Horizontal");
		float input_y = Input.GetAxisRaw("Vertical");
		
		bool isWalking = (Mathf.Abs(input_x) + Mathf.Abs(input_y)) > 0;
		playerAnimator.SetBool("isWalking", isWalking);
		if(isWalking){
			playerAnimator.SetFloat("x", input_x);
			playerAnimator.SetFloat("y", input_y);
			
			transform.position += new Vector3(input_x, input_y, 0.0f).normalized * Time.deltaTime;
		}
	}
}
