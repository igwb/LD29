using UnityEngine;
using System.Collections;

public class SetPlayer : MonoBehaviour {

	public int triggerId;
	private Poem poem;
	
	// Use this for initialization
	void Start () {
		
		poem = GameObject.Find("ScriptHolder").GetComponent<Poem>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if(poem.hasCollected(triggerId)) {
			GameObject.Find("player").rigidbody2D.velocity = new Vector2(0,-3);
			GameObject.Find("player").rigidbody2D.angularDrag = 0;
			GameObject.Find("player").transform.position = transform.position;
			Physics2D.gravity = new Vector2(0, 0);
			Destroy(gameObject);
		}
	}
}
