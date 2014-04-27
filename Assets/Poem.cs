using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Poem : MonoBehaviour {

	private List<int> scriptsFound = new List<int>();
	private List<List<string>> stanzas = new List<List<string>>();
	
	// Use this for initialization
	void Start () {
		
		DontDestroyOnLoad(gameObject);
		
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
		
		/*curScript = new List<string> {
			"What you have seen",
			"will change.",
			"When you face",
			"unknown things."
		};
		
		stanzas.Add(curScript);*/
		
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
		
		stanzas.Add(curScript);
		
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
	
	public int getStanzaCount() {
		
		return stanzas.Count;
	}
	
	public int getVerseCount(int stanza) {
		
		return stanzas[stanza].Count;
	}
	
	public bool hasCollected(int stanza, int verse) {
	
		return hasCollected(createScriptId(stanza, verse));
	}
	
	public bool hasCollected(int scriptId) {
	
		return scriptsFound.Contains(scriptId);
	}
	
	public int createScriptId(int stanza, int verse) {
		
		return (stanza * 100) + verse;
	}
	
	private int getStanzaFromId(int id) {
		
		return (id - getVerseFromId(id)) / 100;
	}
	
	private int getVerseFromId(int id) {
		
		return id % 100;
	}

	public string getVerseById(int scriptId) {
	
		return getVerse(getStanzaFromId(scriptId), getVerseFromId(scriptId));
	}
	
	public string getVerse(int stanza, int verse) {
		
		return stanzas[stanza][verse];
	}
	
	public void foundScript(int stanza, int verse) {
	
		foundScript(createScriptId(stanza, verse));
	}
	
	public void foundScript(int scriptId) {
		
		scriptsFound.Add(scriptId);
	}
}
