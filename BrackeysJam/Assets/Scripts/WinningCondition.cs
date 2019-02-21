using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningCondition : MonoBehaviour {

    public GameObject winMenu;
    public GameObject winLMenu;
    public GameObject panel;
    UIHandling Ui;

	// Use this for initialization
	void Start () {
        winMenu.SetActive(false);
        Ui = gameObject.GetComponent<UIHandling>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Win()
    {
        if (Ui.isMusActi)
        {
            Ui.mainMus.Stop();
            Ui.winMus.Play();
        }
        Cursor.visible = true;
        panel.SetActive(true);
        winMenu.SetActive(true);
        GameObject.Find("GameManager").GetComponent<UIHandling>().inGameUi.SetActive(false);
        Time.timeScale = 0f;

        GetComponent<UIHandling>().addPoints(GetComponent<TimeManagement>().computePoints());
        GetComponent<TimeManagement>().updateTotal();
    }

    public void WinLast()
    {
        if (Ui.isMusActi)
        {
            Ui.mainMus.Stop();
            Ui.winMus.Play();
        }
        GetComponent<UIHandling>().addPoints(GetComponent<TimeManagement>().computePoints());
        GetComponent<TimeManagement>().updateTotal();

        Cursor.visible = true;
        panel.SetActive(true);
        winLMenu.SetActive(true);
        GameObject.Find("GameManager").GetComponent<UIHandling>().inGameUi.SetActive(false);
        Time.timeScale = 0f;
    }

    public void NextLevel()
    {
        Cursor.visible = false;
        winMenu.SetActive(false);
        Time.timeScale = 1f;
        panel.SetActive(false);
        GetComponent<TimeManagement>().timer = 0f;
        Ui.loadNext();
    }
}
