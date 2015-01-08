using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject enemyPrefab;
	public UnityEngine.UI.Text timeText;
	public UnityEngine.UI.Text scoreText;

	int myScore = 0;
	float remainingTime = 60.0f;

	// Use this for initialization
	void Start () {
		MakeEnemys ();
	}
	
	// Update is called once per frame
	void Update () {

		float deltaTime = Time.deltaTime;
		remainingTime -= deltaTime;
		timeText.text = ("" + remainingTime);

		scoreText.text = ("score:" + myScore);
	}

	void MakeEnemys()
	{
		for (int i = 0; i < 10; i++) {
			GameObject enemy = (GameObject)Instantiate(enemyPrefab);
			Vector3 p = enemy.transform.position;
			p.x = Random.Range(-2,2);
			p.y = Random.Range(-4,4);
			enemy.transform.position = p;
		}
	}

	public void AddScore(int add)
	{
		if (remainingTime > 0) {
			myScore += add;		
		}
	}
}
