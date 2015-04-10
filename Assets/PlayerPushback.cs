using UnityEngine;
using System.Collections;

public class PlayerPushback : MonoBehaviour {

	// Use this for initialization
	public float pushAmt=50f;
	public Rigidbody rbody;
	void Start () {
		rbody=GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RelativePush(Vector3 enemyPos){
		Debug.Log("pushCalled");
		Vector3 pushDir= transform.position-enemyPos;
		rbody.AddForce(pushDir,ForceMode.Impulse);


	}

}
