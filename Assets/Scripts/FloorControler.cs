using UnityEngine;
using System.Collections;

public class FloorControler : MonoBehaviour {

	public float charge = 0;
	public float dischargePerSecond = 1;
	
	public Gradient colors;
	
	public bool noDischarge;
	
	public bool playEffect = false;
	public ParticleSystem effect;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(!noDischarge) {
			charge = Mathf.Max(0, charge - (dischargePerSecond * Time.deltaTime));
		}
		
		GetComponent<SpriteRenderer>().color = colors.Evaluate(charge);
	}
	
	void OnCollisionStay2D(Collision2D coll) {
	
		charge = 1;

	}
	
	void OnCollisionEnter2D(Collision2D coll) {
	
		if(playEffect) {
			Instantiate(effect,transform.position, transform.rotation);
		}
	}
}
