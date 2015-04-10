using UnityEngine;
using System.Collections;

public class SpawnSpawner : MonoBehaviour {

	// Use this for initialization
	public GameObject spawner;
	public float delay=5f;
	void Start () {
		StartCoroutine("SpawnerCoroutine");
	}

	public IEnumerator SpawnerCoroutine(){
		while(true){
			Instantiate(spawner,new Vector3(Random.Range(-7f,7f),0f,Random.Range(-7f,7f)),Quaternion.identity);
			yield return new WaitForSeconds(delay);
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
