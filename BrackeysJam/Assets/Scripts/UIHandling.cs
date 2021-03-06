﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIHandling : MonoBehaviour {

    public GameObject panel;
    public GameObject player;
    public GameObject inGameUi;
    public GameObject pauseMen;
    public GameObject winMenu;
    public GameObject winLMenu;

    int flowerCount = 0;
    public string playerPseudo = "";

    public AudioSource mainMus;
    public AudioSource titleMus;
    public AudioSource winMus;
    public bool isMusActi = true;

    public Button soundButton;
    private Image soundButt;

    public GameObject titleMenu;

    BulletScript bSc;

    public int points = 0;
    string actualSC;
    string nextLev;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Use this for initialization
    void Start () {
        soundButt = soundButton.GetComponent<Image>();
        player = GameObject.Find("Player");
        panel.SetActive(false);
        if (player)
            bSc = player.GetComponentInChildren<BulletScript>();
	}
	
	// Update is called once per frame
	void Update () {

        if (player)
        {
            player.GetComponentInChildren<BulletScript>().enabled = true;
        }

        if (panel.activeSelf)
        {
            Cursor.visible = true;
        }

        if (SceneManager.GetActiveScene().name == "Title")
            soundButt = GameObject.Find("SoundButton").GetComponent<Image>();

        if (isMusActi)
            soundButt.sprite = Resources.Load<Sprite>("Sprites/MusicOn");

        else
            soundButt.sprite = Resources.Load<Sprite>("Sprites/MusicOff");

        player = GameObject.Find("Player");
        if (player)
            bSc = player.GetComponentInChildren<BulletScript>();

        actualSC = SceneManager.GetActiveScene().name;

        if (Input.GetKeyDown(KeyCode.Escape) && 
            (SceneManager.GetActiveScene().name != "Title")
            && winMenu.activeSelf == false)
        {
            if (!panel.activeSelf)
            {
                Cursor.visible = true;
                Pause();
            }

            else
            {
                Cursor.visible = false;
                Resume();
            }
        }
	}

    public void Pause()
    {
        if (bSc)
            bSc.enabled = false;
        inGameUi.SetActive(false);
        pauseMen.SetActive(true);
        panel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        if (bSc)
            bSc.enabled = true;
        inGameUi.SetActive(true);
        pauseMen.SetActive(false);
        panel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Title()
    {
        if (isMusActi)
        {
            mainMus.Stop();
            titleMus.Play();
        }
        panel.SetActive(false);
        winLMenu.SetActive(false);
        inGameUi.SetActive(false);
        winMenu.SetActive(false);
        Time.timeScale = 1f;
        gameObject.GetComponent<TimeManagement>().timer = 0f;
        pauseMen.SetActive(false);
        titleMenu.SetActive(true);
        SceneManager.LoadScene("Title");
        Destroy(gameObject);
    }

    public void addPoints(int pts_)
    {
        if (bSc)
            bSc.enabled = false;
        points += pts_;
    }

    public void loadLevel1()
    {
        flowerCount = 0;
        if (isMusActi)
        {
            titleMus.Stop();
            mainMus.Play();
        }
        gameObject.GetComponent<TitleMenuHandle>().menu.SetActive(false);

        panel.SetActive(false);
        inGameUi.SetActive(true);
        pauseMen.SetActive(false);
        winMenu.SetActive(false);
        titleMenu.SetActive(false);

        nextLev = "Level2";
        gameObject.GetComponent<TimeManagement>().timer = 0f;

        SceneManager.LoadScene("Level1");
    }

    public void loadLevel2()
    {
        flowerCount = 0;
        if (isMusActi)
        {
            titleMus.Stop();
            mainMus.Play(); }
        gameObject.GetComponent<TitleMenuHandle>().menu.SetActive(false);

        panel.SetActive(false);
        inGameUi.SetActive(true);
        pauseMen.SetActive(false);
        winMenu.SetActive(false);
        titleMenu.SetActive(false);

        nextLev = "Level3";
        gameObject.GetComponent<TimeManagement>().timer = 0f;

        SceneManager.LoadScene("Level2");
    }

    public void loadLevel3()
    {
        flowerCount = 0;
        if (isMusActi)
        {
            titleMus.Stop();
            mainMus.Play();
        }
        gameObject.GetComponent<TitleMenuHandle>().menu.SetActive(false);

        panel.SetActive(false);
        inGameUi.SetActive(true);
        pauseMen.SetActive(false);
        winMenu.SetActive(false);
        titleMenu.SetActive(false);

        nextLev = "Level4";
        gameObject.GetComponent<TimeManagement>().timer = 0f;

        SceneManager.LoadScene("Level3");
    }

    public void loadLevel4()
    {
        flowerCount = 0;
        if (isMusActi)
        {
            titleMus.Stop();
            mainMus.Play();
        }
        gameObject.GetComponent<TitleMenuHandle>().menu.SetActive(false);

        panel.SetActive(false);
        inGameUi.SetActive(true);
        pauseMen.SetActive(false);
        winMenu.SetActive(false);
        titleMenu.SetActive(false);

        nextLev = "Level5";
        gameObject.GetComponent<TimeManagement>().timer = 0f;

        SceneManager.LoadScene("Level4");
    }

    public void loadLevel5()
    {
        flowerCount = 0;
        if (isMusActi)
        {
            titleMus.Stop();
            mainMus.Play();
        }
        gameObject.GetComponent<TitleMenuHandle>().menu.SetActive(false);

        panel.SetActive(false);
        inGameUi.SetActive(true);
        pauseMen.SetActive(false);
        winMenu.SetActive(false);
        titleMenu.SetActive(false);

        nextLev = "Level6";
        gameObject.GetComponent<TimeManagement>().timer = 0f;

        SceneManager.LoadScene("Level5");
    }

    public void loadLevel6()
    {
        flowerCount = 0;
        if (isMusActi)
        {
            titleMus.Stop();
            mainMus.Play();
        }
        gameObject.GetComponent<TitleMenuHandle>().menu.SetActive(false);

        panel.SetActive(false);
        inGameUi.SetActive(true);
        pauseMen.SetActive(false);
        winMenu.SetActive(false);
        titleMenu.SetActive(false);

        nextLev = "End";
        gameObject.GetComponent<TimeManagement>().timer = 0f;

        SceneManager.LoadScene("Level6");
    }

    public void loadNext()
    {
        flowerCount = 0;
        if (isMusActi)
        {
            mainMus.Play();
            titleMus.Stop();
        }
            switch (nextLev)
        {
            case "Level1":
                loadLevel1();
                break;
            case "Level2":
                loadLevel2();
                break;
            case "Level3":
                loadLevel3();
                break;
            case "Level4":
                loadLevel4();
                break;
            case "Level5":
                loadLevel5();
                break;
            case "Level6":
                loadLevel6();
                break;
            default:
                Debug.Log("WTF");
                break;
        }
    }

    public void changeSound()
    {


        if (isMusActi)
        {
            isMusActi = false;
            titleMus.Stop();
            mainMus.Stop();
            winMus.Stop();
        }

        else
        {
            isMusActi = true;
            if (SceneManager.GetActiveScene().name == "Title")
            {
                titleMus.Play();
            }

            else
            {
                mainMus.Play();
            }
        }
    }

    public void changedText(string newText)
    {
        playerPseudo = newText;

    }

    public void registerScore()
    {
        FileStream fileStream = new FileStream(@"leaderboard.txt",
                                               FileMode.OpenOrCreate,
                                               FileAccess.ReadWrite,
                                               FileShare.None);

        if (fileStream != null)
        {
            string line = playerPseudo + "        " + GetComponent<TimeManagement>().getFinalTime() 
                                       + "        " + points.ToString() + "\n";
            byte[] bytes = Encoding.ASCII.GetBytes(line);
            fileStream.Write(bytes, 0, line.Length);
            fileStream.Close();
            Debug.Log("Score registered !");
        }
    }

    public void addToFlower()
    {
        flowerCount += 1;
        addPoints(3000);
    }

    public int getFlowers()
    {
        return flowerCount;
    }

    public void setFlowers(int flow)
    {
        flowerCount = flow;
    }
}
