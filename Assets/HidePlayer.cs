using UnityEngine;
using System.Collections;

public class HidePlayer : MonoBehaviour {

	public int hideWhenFound;
	public int showWhenFound;
	
	private Poem poem;
	
	// Use this for initialization
	void Start () {
		
		poem = GameObject.Find("ScriptHolder").GetComponent<Poem>();
	}
	
	// Update is called once per frame
	void Update () {
		if(poem.hasCollected(hideWhenFound)) {
		
			if(poem.hasCollected(showWhenFound)) {
			
				gameObject.GetComponent<SpriteRenderer>().enabled = true;
			} else {
			
				gameObject.GetComponent<SpriteRenderer>().enabled = false;
			}
		}
	}
}
