using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ChangeLiveText : MonoBehaviour {

    public TextMeshProUGUI m_text;
    GameObject gameman;

	// Use this for initialization
	void Start () {
        m_text = GetComponent<TextMeshProUGUI>();
        gameman = GameObject.Find("GameManager");
    }

    private void Update()
    {
        if (m_text && gameman)
        {
            m_text.text = gameman.GetComponent<UIHandling>().points.ToString() + " points";
        }
    }
}
