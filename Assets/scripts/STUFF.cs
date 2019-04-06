using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class STUFF : MonoBehaviour {

    public GameObject enemy_Sprite;
    public GameObject title;
    public GameObject gameovertitle;
    public GameObject playbutton;
    public GameObject Restartbutton;
    public bool IsPlaying = false;
    public float time;

    public static STUFF Instance;
	// Use this for initialization
	void Start () {
        Instance = this;
        gameovertitle.SetActive(false);
        Restartbutton.SetActive(false);
        title.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {

        time += Time.deltaTime;

        if (time>0.5f&&IsPlaying ==true)
        {
            Vector3 position = new Vector3(Random.Range(15.0f, 16.0f), Random.Range(4.0f, -3.0f), 0);
                GameObject enemy = Instantiate(enemy_Sprite, position, Quaternion.identity) as GameObject;
                enemy.transform.Rotate(0, 180f, 0);
                time = 0f;
        }
	}
    
    public void GameStart()
    {
        IsPlaying = true;
        playbutton.SetActive (false);
        title.SetActive(false);
      
    }  

    public void GameOver()
    {
        IsPlaying = false;
        gameovertitle.SetActive(true);
        Restartbutton.SetActive(true);
    }

    public void ResetGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
