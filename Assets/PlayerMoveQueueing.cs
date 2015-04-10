using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PlayerMoveQueueing: MonoBehaviour {

	// Use this for initialization
	public List<Vector3> queuedStepList = new List<Vector3>();
	public List<Vector3> shotTargets = new List<Vector3>();
	public float stepSize=5f;
	public float stepDelay=1f;
	public Vector3 shootSignalVector=new Vector3(100f,100f,100f);
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space")){
			StartCoroutine("Queueing");
		}

		if(Input.GetKeyDown(KeyCode.H)){
			StartCoroutine("PlaybackQue");
		}


		if (Input.GetMouseButtonDown(0)){

		Ray cursorRay= Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit cursorRayHit= new RaycastHit();

		if(Physics.Raycast(cursorRay, out cursorRayHit, 1000f)){
			
				queuedStepList.Add(transform.position);
				queuedStepList.Add(shootSignalVector);
			
				Vector3 targetPos=cursorRayHit.point;
				targetPos.y=0f;
			

				shotTargets.Add(targetPos);
		}
		}

	
	}


	public IEnumerator PlaybackQue(){
		StopCoroutine("Queueing");
		GetComponent<PlayerController>().canMove=false;
		int i=0;
		while(i<=queuedStepList.Count){
			transform.position=queuedStepList[i];
			i++;
			yield return new WaitForSeconds(stepDelay);
		}
		queuedStepList.Clear();
		GetComponent<PlayerController>().canMove=true;
		yield break;
		
	}

	public IEnumerator Queueing(){
		Vector3 lastQuePos=transform.position;
		queuedStepList.Add(lastQuePos);
		while(true){
			if(Vector3.Distance(transform.position,lastQuePos)>stepSize){
				queuedStepList.Add(transform.position);
				lastQuePos=transform.position;

			}
			yield return 0;

		}

	}
}
