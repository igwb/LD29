using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Poem : MonoBehaviour {

	private List<int> scriptsFound = new List<int>();
	
	private List<List<string>> stanzas = new List<List<string>>();
	
	
	private Vector2 scrollPosition = new Vector2(0,0);
	
	
	// Use this for initialization
	void Start () {
		
		List<string> curScript = new List<string> {
			"You are",
			"on a quest",
			"to find",
			"what lies beneath",
			"the mind.",
		};
		
		stanzas.Add(curScript);
		
		curScript = new List<string> {
			"In order to find",
			"what makes the minds",
			"you will need to look",
			"at different kinds."
		};
		
		stanzas.Add(curScript);
		
		curScript = new List<string> {
			"What you will find,",
			"will change",
			"how you see",
			"the things in life.",
		};
		
		stanzas.Add(curScript);
		
		curScript = new List<string> {
			"What you have seen",
			"will change.",
			"When you face",
			"unknown things."
		};
		
		stanzas.Add(curScript);
		
		curScript = new List<string> {
			"Discover others!",
			"Discover yourself!",
			"Become whole!",
			"Become a different self!"
		};
		
		stanzas.Add(curScript);
		
		curScript = new List<string> {
			"Once you completed",
			"the task fate has assigned",
			"you will find",
			"REALITY",
			"unfortunately"
		};
		
		stanzas.Add(curScript);
		
		curScript = new List<string> {
			"Now you have discovered,",
			"now you have uncovered,",
			"what you can't unsee.",
			"Reality has ceased to be.",
		};
		
		curScript = new List<string> {
			"Beneath it's surface",
			"reality just",
			"is",
			"EMPTY"
		};
		
		stanzas.Add(curScript);
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
