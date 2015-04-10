using UnityEngine;
using System.Collections;

public class SpawnEnemies : MonoBehaviour {

	// Use this for initialization
	public GameObject Enemy;
	public float delay =3f;
	void Start () {
		StartCoroutine(SpawnCoroutine());
	}
	public IEnumerator SpawnCoroutine(){
		while(true){
			Instantiate(Enemy,transform.position,Quaternion.identity);
			yield return new WaitForSeconds(delay);
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
