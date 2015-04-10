using UnityEngine;
using System.Collections;

public class HomingEnemy : MonoBehaviour {

	// Use this for initialization
	public float moveSpeed=5f;
	public Rigidbody rbody;
	public Transform player;
	public float pushbackForce=50f;

	void Start () {
		rbody=GetComponent<Rigidbody>();
		player=GameObject.Find("Player").transform;
	}
	
	// Update is called once per frame
	void FixedUpdate(){
		transform.LookAt(player);
		float moveVariety= Random.Range(-5f,5f);
		rbody.AddRelativeForce(new Vector3 (moveVariety,moveVariety,10f)*moveSpeed);
	}

	void Update () {
	
	}

	void OnCollisionEnter(Collision col){

		if(col.gameObject.name=="Player"){
			col.gameObject.GetComponent<PlayerPushback>().RelativePush(transform.position);
			GetComponent<EnemyPushback>().RelativePush(pushbackForce);
		}
		else if(col.gameObject.name=="walls"){
			GetComponent<KillEnemy>().Kill();
		}
	}
}
