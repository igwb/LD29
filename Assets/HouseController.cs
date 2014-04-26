using UnityEngine;
using System.Collections;


public class HouseController : MonoBehaviour {

	public Sprite[] sprites;
	public float SecondsPerFrame = 30.0f;
	public float randomTime = 30.0f;

	private float currentInterval;
	private float lastUpdate;
	private bool updated = false;

	// Use this for initialization
	void Start () {
	
		updateSprite();
	}
	
	// Update is called once per frame
	void Update () {
		
		updated = !(Time.timeSinceLevelLoad - lastUpdate >= currentInterval);
		
		if(!updated) {
		
			updateSprite();
		}
	}
	
	private void updateSprite() {
		currentInterval = SecondsPerFrame + Random.Range(0.0f, randomTime);
	
		lastUpdate = Time.timeSinceLevelLoad;
		updated = true;
		
		GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Length)];
	}
}
