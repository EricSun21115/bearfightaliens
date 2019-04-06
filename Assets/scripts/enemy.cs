using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
    public GameObject enemy_Sprite;
    
	void Start () {
		for(int i=0;i<200; i++)
        {
            Vector3 position = new Vector3(Random.Range(5.0f, 1000.0f), Random.Range(4.0f, -3.0f), 0);
            GameObject enemy = Instantiate(enemy_Sprite, position, Quaternion.identity) as GameObject;
            enemy.transform.Rotate(0, 180f, 0);
        }

	}
    

}
