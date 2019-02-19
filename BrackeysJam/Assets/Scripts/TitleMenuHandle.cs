using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenuHandle : MonoBehaviour {

    public GameObject menu;
    public GameObject credits;
    public GameObject help;
    public GameObject levels;

    public GameObject torch;
	// Use this for initialization
	void Start () {
        changeUIState(false);
 
	}
	
	// Update is called once per frame
	void Update () {
        torch = GameObject.Find("Torch");
        Cursor.visible = false;
        if (SceneManager.GetActiveScene().name == "Title")
        {
            if (Input.GetKeyDown(KeyCode.Escape) && menu.activeSelf)
            {
                changeUIState(false);
            }
        }
	}

    public void changeUIState(bool state)
    {
        if (torch)
        {
            torch.GetComponent<GuideTheTorch>().enabled = !state;
        }
        menu.SetActive(state);
        credits.SetActive(state);
        help.SetActive(state);
        levels.SetActive(state);
    }

    public void displayLevels()
    {
        if (torch)
        {
            torch.GetComponent<GuideTheTorch>().enabled = false;
        }
        menu.SetActive(true);
        levels.SetActive(true);
    }

    public void displayCredits()
    {
        if (torch)
        {
            torch.GetComponent<GuideTheTorch>().enabled = false;
        }
        menu.SetActive(true);
        credits.SetActive(true);
    }

    public void displayHelp()
    {
        if (torch)
        {
            torch.GetComponent<GuideTheTorch>().enabled = false;
        }
        menu.SetActive(true);
        help.SetActive(true);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
