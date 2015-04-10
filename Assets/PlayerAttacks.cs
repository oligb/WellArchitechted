﻿using UnityEngine;
using System.Collections;

public class PlayerAttacks : MonoBehaviour {

	// Use this for initialization
	public Vector3 targetPos;
	public GameObject bullet1;
	public int numShots=20;
	public Vector3 direction;
	public float bulletSpeed=20f;
	public Camera mainCam;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Melee(){

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
