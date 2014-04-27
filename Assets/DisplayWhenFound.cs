using UnityEngine;
using System.Collections;

public class DisplayWhenFound : MonoBehaviour {

	public int triggerScript;
	private Poem poem;
	
	// Use this for initialization
	void Start () {
		
		poem = GameObject.Find("ScriptHolder").GetComponent<Poem>();
	
	}
	
	// Update is called once per frame
	void Update () {
		
		GetComponent<SpriteRenderer>().enabled = poem.hasCollected(triggerScript);
	}
}
