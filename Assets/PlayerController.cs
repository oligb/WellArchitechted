﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {

	public float moveSpeed=2f;
	public Rigidbody rbody;
	public GameObject bullet1;
	public int numShots=20;
	public Vector3 direction;
	public float bulletSpeed=20f;
	public Camera mainCam;

	public GameObject currentWeapon;
	public bool canMove=true;



	void Start () {
		rbody= GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float inputX =  Input.GetAxis("Horizontal")*Time.deltaTime;
		float inputY =  Input.GetAxis("Vertical")*Time.deltaTime; 

	if(canMove){
		rbody.AddForce(new Vector3(inputX,0f,inputY)*moveSpeed);

			/*
		Ray cursorRay= Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit cursorRayHit= new RaycastHit();

		if(Physics.Raycast(cursorRay, out cursorRayHit, 1000f)){
			
			Vector3 targetPos=cursorRayHit.point;
			targetPos.y=0f;
			
			if (Input.GetMouseButtonDown(0)){
				Shoot(transform.position,targetPos);
			}
		}
		*/
	}




	}


	public void Shoot(Vector3 playerPos, Vector3 targetPos){
		Camera.main.gameObject.GetComponent<CamShake>().TriggerShake();
		direction= targetPos-playerPos;
		for(int i=0; i<numShots; i++){
			GameObject bullet= Instantiate(bullet1, playerPos,Quaternion.identity) as GameObject;
			bullet.transform.LookAt(targetPos);
			bullet.transform.Rotate(0f,Random.Range(-15f,15f),0f);
			bullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward*bulletSpeed*Random.Range(.8f,1.2f),ForceMode.Impulse);
			
		}
	}


}

