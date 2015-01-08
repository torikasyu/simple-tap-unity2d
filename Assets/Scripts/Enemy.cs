using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		Destroy(gameObject);
	}

	void OnDestroy(){
		GameObject go = GameObject.Find ("GameManager");
		if (go != null) {
			GameManager gm = go.GetComponent(typeof(GameManager)) as GameManager;
			gm.AddScore(100);
		}
	}
}
