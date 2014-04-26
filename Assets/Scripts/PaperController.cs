using UnityEngine;
using System.Collections;

public class PaperController : MonoBehaviour {

	
	public int stanza = 0;
	public int verse = 0;


	private Poem poem;
	
	// Use this for initialization
	void Start () {
	
		poem = GameObject.Find("ScriptHolder").GetComponent<Poem>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter2D(Collider2D coll) {
	
	
		poem.foundScript(stanza, verse);
		GetComponent<AudioSource>().Play();
		
		Destroy(gameObject, GetComponent<AudioSource>().clip.length);
	
	}
}
