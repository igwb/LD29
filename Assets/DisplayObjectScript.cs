using UnityEngine;
using System.Collections;

public class DisplayObjectScript : MonoBehaviour {
	
	public DisplayRecieverScript displayReciever;
	public SwitchScene switchSceneReciever;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionStay2D(Collision2D coll) {
		
		if(displayReciever != null) {
			displayReciever.setVisible(true);
		}
		
		if(switchSceneReciever != null) {
			switchSceneReciever.setCanSwitch(true);
		}
	}
}
