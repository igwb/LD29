using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HUDControl : MonoBehaviour {

	public GUISkin skin;
	
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
	
	void OnGUI() {
		
		GUI.skin = skin;
		
		GUILayout.BeginArea(new Rect(10, 0, 250, 600));

		GUILayout.BeginScrollView(scrollPosition, true, false);
		GUILayout.EndScrollView();
		
		scrollPosition = GUILayout.BeginScrollView(scrollPosition, GUIStyle.none);

		
		GUILayout.BeginVertical();

		for (int stanza = 0; stanza < stanzas.Count; stanza ++) {
			
			GUILayout.BeginHorizontal();
			
			GUILayout.BeginVertical();
			GUILayout.Label((stanza + 1).ToString());
			GUILayout.EndVertical();
			
			
			GUILayout.BeginVertical();
			for(int verse = 0; verse < stanzas[stanza].Count; verse ++) {
				if (scriptsFound.Contains(createVerseId(stanza, verse))) {
					
					GUILayout.Label(stanzas[stanza][createVerseId(stanza, verse)]);
				} else {
					
					GUILayout.Label(". . .");
				}
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
		
		
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
		GUILayout.EndArea();
	}
	
	public int createVerseId(int stanza, int verse) {
	
		return (stanza * 100) + verse;
	}
	
	private int getStanzaFromId(int id) {
	
		return (id - getVerseFromId(id)) / 100;
	}
	
	private int getVerseFromId(int id) {
	
		return id % 100;
	}
	
	public void attributeScript(int scriptId) {
		
		scriptsFound.Add(scriptId);
	}
}
