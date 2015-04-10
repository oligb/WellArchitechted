using UnityEngine;
using System.Collections;

public class SpawnerDamage : MonoBehaviour {

	// Use this for initialization
	public float damagePerBullet=50f;
	public float currentHp=100f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(currentHp<=0){
			GetComponent<KillSpawner>().Kill();
		}
	
	}
	void OnCollisionEnter(Collision col){
		currentHp-=damagePerBullet;
	}
}
