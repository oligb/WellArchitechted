﻿using UnityEngine;
using System.Collections;

public class KillSpawner : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Kill(){
		Destroy(gameObject);
	}
}
