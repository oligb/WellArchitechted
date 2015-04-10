using UnityEngine;
using System.Collections;

public class KillEnemy : MonoBehaviour {

	// Use this for initialization
	public GameObject deathParticles;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Kill(){
		Instantiate(deathParticles,transform.position,Quaternion.identity);
		Destroy(gameObject);

	}
}
