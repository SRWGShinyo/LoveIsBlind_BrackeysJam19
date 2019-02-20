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
            case "level4":
                loadLevel4();
                break;
            case "level5":
                loadLevel5();
                break;
            case "level6":
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
}
