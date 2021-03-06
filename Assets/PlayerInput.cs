﻿using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

	public PlayerMovement movement;
	public PlayerAttacks attacks;
	void Start () {
		movement= GetComponent<PlayerMovement>();
		attacks= GetComponent<PlayerAttacks>();
	}
	
	// Update is called once per frame
	void Update () {
		float inputX =  Input.GetAxis("Horizontal");
		float inputY =  Input.GetAxis("Vertical"); 
		movement.Move(inputX,inputY);

	}
}
