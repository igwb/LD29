using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HUDControl : MonoBehaviour {

	public GUISkin skin;
	
	private List<int> scriptsFound = new List<int>();

	private Poem poem;


	private Vector2 scrollPosition = new Vector2(0,0);
	

	// Use this for initialization
	void Start () {

		poem = GameObject.Find("ScriptHolder").GetComponent<Poem>();
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

		for (int stanza = 0; stanza < poem.getStanzaCount(); stanza ++) {
			
			GUILayout.BeginHorizontal();
			
			GUILayout.BeginVertical();
			GUILayout.Label((stanza + 1).ToString());
			GUILayout.EndVertical();
			
			
			GUILayout.BeginVertical();
			for(int verse = 0; verse < poem.getVerseCount(stanza); verse ++) {
				if (poem.hasCollected(stanza, verse)) {
					
					GUILayout.Label(poem.getVerse(stanza, verse));
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
}
