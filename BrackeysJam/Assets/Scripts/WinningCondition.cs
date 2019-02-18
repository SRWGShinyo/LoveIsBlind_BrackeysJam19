using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningCondition : MonoBehaviour {

    public GameObject winMenu;
    public GameObject panel;

	// Use this for initialization
	void Start () {
        winMenu.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Win()
    {
        panel.SetActive(true);
        winMenu.SetActive(true);
        GameObject.Find("GameManager").GetComponent<UIHandling>().inGameUi.SetActive(false);
        Time.timeScale = 0f;

        GetComponent<UIHandling>().addPoints(GetComponent<TimeManagement>().computePoints());
    }

    public void NextLevel()
    {
        winMenu.SetActive(false);
        Time.timeScale = 1f;
        panel.SetActive(false);
        GetComponent<TimeManagement>().timer = 0f;
        Debug.Log("Loading Next level...");
    }
}
