using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform followThis;
	
	public bool lockX;
	public bool lockY;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
		Vector3 currentPos = transform.position;
		Vector3 nextPos = new Vector3(followThis.position.x, followThis.position.y, currentPos.z);
		
		if(lockX) {
			nextPos = new Vector3(nextPos.x, followThis.position.y, nextPos.z);
		}
		
		if(lockY) {
			nextPos = new Vector3(nextPos.x, currentPos.y, currentPos.z);
		}
		
		transform.position = nextPos;
	}
}
