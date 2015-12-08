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
		

	}
}
