using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManagement : MonoBehaviour {
    public float timer = 0f;
    public float minutes = 0f;
    public float seconds = 0f;

    public float totalMin = 0f;
    public float totalSec = 0f;

    string time;

	// Update is called once per frame
	void Update () {
        if (Time.timeScale != 0)
        {
            timer += Time.deltaTime;
        }

        string mins;
        string secs;

        minutes = Mathf.Floor(timer / 60);
        seconds = Mathf.RoundToInt(timer % 60);

        if (minutes < 10)
        {
            mins = "0" + minutes.ToString();
        }

        else
        {
            mins = minutes.ToString();
        }

        if (seconds < 10)
        {
            secs = "0" + seconds.ToString();
        }

        else
        {
            secs = seconds.ToString();
        }

        time = mins + ":" + secs;

	}

    public string getTime()
    {
        return time;
    }

    public int computePoints()
    {
        return (int)(5000 - (100 * minutes + 10 * seconds));
    }

    public void updateTotal()
    {
        totalSec += seconds;
        if (totalSec >= 60)
        {
            totalMin += totalSec / 60;
            totalSec = totalSec % 60;
        }
        totalMin += minutes;
    }

    public string getFinalTime()
    {
        string finMins = totalMin.ToString();
        string finSecs = totalSec.ToString();

        if (totalMin < 10)
        {
            finMins = "0" + totalMin.ToString();
        }

        if (totalSec < 10)
        {
            finSecs = "0" + totalSec.ToString();
        }

        return finMins + ":" + finSecs;
    }
}
