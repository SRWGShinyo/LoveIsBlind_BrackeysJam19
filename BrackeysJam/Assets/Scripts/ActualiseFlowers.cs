using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ActualiseFlowers : MonoBehaviour {

    public GameObject gameMan;
    public TextMeshProUGUI meshpro;
    // Use this for initialization
    void Start()
    {
        gameMan = GameObject.Find("GameManager");
        meshpro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update () {
        if (meshpro && gameMan)
        {
            meshpro.text = gameMan.GetComponent<UIHandling>().getFlowers().ToString();
        }
	}
}
