using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SetRecordTime : MonoBehaviour
{
    public float levelTime = 0.0f;
    public bool updateTimer = false;
    public TextMeshProUGUI timer;
    // Start is called before the first frame update
    void Start()
    {
        updateTimer = true;
        levelTime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (updateTimer)
            levelTime += Time.deltaTime;
    }

    void LevelEnded()
    {
        updateTimer = false;
        timer.text += levelTime.ToString()+"\n";
        levelTime = 0.0f;
    }
}