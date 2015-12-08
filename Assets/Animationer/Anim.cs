using UnityEngine;
using System.Collections;

public class Anim : MonoBehaviour {
	Animator anim;
	
	
	void Start ()
	{
		anim = GetComponent<Animator>();
	}
	
	
	void Update ()
	{
		float move = Input.GetAxis ("Horizontal");
		anim.SetFloat("Speed", move);
		
		bool Jump = Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetAxisRaw("Jump") >= 0.75;
		anim.SetBool ("Jump", Jump);
	}
}
