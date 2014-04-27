using UnityEngine;
using System.Collections;

public class RemovePlayer : MonoBehaviour {

	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		

	}
	
	public void OnCollisionEnter2D(Collision2D coll) {
	
		Destroy(GameObject.Find("player"));
		Destroy(Camera.main.GetComponent<CameraFollow>());
		GameObject.Find("ScriptHolder").GetComponent<AudioSource>().Stop();
	}
	
}
