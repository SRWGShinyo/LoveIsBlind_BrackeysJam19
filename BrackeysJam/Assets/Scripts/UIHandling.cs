using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIHandling : MonoBehaviour {

    public GameObject panel;
    public GameObject player;
    public GameObject inGameUi;
    public GameObject pauseMen;
    public GameObject winMenu;

    BulletScript bSc;

    public int points = 0;
    string actualSC;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        panel.SetActive(false);
        if (player)
            bSc = player.GetComponentInChildren<BulletScript>();
	}
	
	// Update is called once per frame
	void Update () {

        if (!player)
        {
            player = GameObject.Find("Player");
            if (player)
                bSc = player.GetComponentInChildren<BulletScript>();
        }
        actualSC = SceneManager.GetActiveScene().name;

        if (SceneManager.GetActiveScene().name == "Title")
        {
            inGameUi.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape) && 
            (SceneManager.GetActiveScene().name != "Title")
            && winMenu.activeSelf == false)
        {
            if (!panel.activeSelf)
            {
                Pause();
            }

            else
            {
                Resume();
            }
        }
	}

    public void Pause()
    {
        bSc.enabled = false;
        inGameUi.SetActive(false);
        pauseMen.SetActive(true);
        panel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        bSc.enabled = true;
        inGameUi.SetActive(true);
        pauseMen.SetActive(false);
        panel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Title()
    {
        if (panel.activeSelf)
            panel.SetActive(false);
        pauseMen.SetActive(false);
        inGameUi.SetActive(false);
        winMenu.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Title");
    }

    public void addPoints(int pts_)
    {
        bSc.enabled = false;
        points += pts_;
    }
}
