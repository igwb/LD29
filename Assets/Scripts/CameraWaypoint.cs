using UnityEngine;
using System.Collections;

public class CameraWaypoint : MonoBehaviour {

	public Transform waypoint1;
	public Transform waypoint2;

	public bool triggerIsX = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	void FixedUpdate() {
	
		Vector3 currentPos = transform.position;
		Vector3 nextPos;
	
		if(triggerIsX) {
			if(currentPos.x >= waypoint1.position.x && currentPos.x <= waypoint2.position.x) {
				
				float xDistance = waypoint1.position.x - waypoint2.position.x;
				float yDistance = Mathf.Abs(waypoint1.position.y - waypoint2.position.y);
				
				if(waypoint1.position.y > waypoint2.position.y) {
					yDistance *= -1;
				}
				
				float percentTraveled = (currentPos.x - waypoint1.position.x) / Mathf.Abs(xDistance);
				
				nextPos = new Vector3(currentPos.x, waypoint1.position.y + (yDistance * percentTraveled), currentPos.z);
				
				transform.position = nextPos;	
			}
		}
	}
}
