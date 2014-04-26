using UnityEngine;
using System.Collections;

public class DisplayRecieverScript : MonoBehaviour {

	public SpriteRenderer toggleThis;
	public float hideDelay = 1.0f;

	private float lastVisible;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(toggleThis.enabled) {
			toggleThis.enabled = !(Time.timeSinceLevelLoad - lastVisible >= hideDelay);
		}
	
	}
	
	public void setVisible(bool visible) {
		
		lastVisible = Time.timeSinceLevelLoad;
		toggleThis.enabled = visible;
	}
	
	public bool isVisible() {
	
		return toggleThis.enabled;
	}
}
