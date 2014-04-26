using UnityEngine;
using System.Collections;

public class PaperController : MonoBehaviour {

	
	public int stanza = 0;
	public int verse = 0;


	private HUDControl hud;
	
	// Use this for initialization
	void Start () {
		hud = GameObject.Find("HUD").GetComponent<HUDControl>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter2D(Collider2D coll) {
	
	
		hud.attributeScript(hud.createVerseId(stanza, verse));
		GetComponent<AudioSource>().Play();
		
		Destroy(gameObject, GetComponent<AudioSource>().clip.length);
	
	}
}
