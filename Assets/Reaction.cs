using UnityEngine;
using System.Collections;

public class Reaction : MonoBehaviour {

	public int[] triggerScripts;

	public bool destroyOnTrigger;
	
	public bool changeColorOnTrigger;
	
	public bool chargeOnTrigger;
	
	public Gradient colors;

	

	private Poem poem;
	
	// Use this for initialization
	void Start () {
	
		poem = GameObject.Find("ScriptHolder").GetComponent<Poem>();
	}
	
	// Update is called once per frame
	void Update () {
	
		bool canTrigger = true;
	
		foreach(int id in triggerScripts) {
			canTrigger = canTrigger && poem.hasCollected(id);
		}
		
		if(canTrigger) {
		
			if(destroyOnTrigger) {
				Destroy(gameObject);
				return;
			}
			
			
			foreach(FloorControler fc in GetComponentsInChildren<FloorControler>()) {
				if(chargeOnTrigger) {
					fc.charge = 1;
					fc.noDischarge = true;
				}
				
				if(changeColorOnTrigger) {
					fc.colors = colors;
				}
			}
		}
	}
}
