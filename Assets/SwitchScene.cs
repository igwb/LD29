using UnityEngine;
using System.Collections;

public class SwitchScene : MonoBehaviour {

	private bool canSwitch;
	private float lastActive;
	public float hideDelay = 0.2f;
	
	public int loadThis;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(canSwitch) {
			canSwitch = !(Time.timeSinceLevelLoad - lastActive >= hideDelay);
		}
		
		if(Input.GetAxis("Action") > 0 && canSwitch) {
			Application.LoadLevel(loadThis);
		}
	}
	
	public void setCanSwitch(bool allowSwitching) {
	
		lastActive = Time.timeSinceLevelLoad;
		canSwitch = allowSwitching;
	}
}
