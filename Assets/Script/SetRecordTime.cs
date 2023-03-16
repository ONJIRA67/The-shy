using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SetRecordTime : MonoBehaviour
{
    public float levelTime;
    public bool updateTimer = false;
    public TextMeshProUGUI finishTime;   
    public TextMeshProUGUI winTime;   
    // public PlayerHealth player;
    // Start is called before the first frame update
    public void StartTime()
    {
        updateTimer = true;
        levelTime = 0.0f;
    }

    // Update is called once per frame
    public void Update()
    {
        if (updateTimer)
            levelTime += Time.deltaTime;

            
    }

    public void LevelEnded()
    {
        Debug.Log(levelTime);
        updateTimer = false;
        finishTime.text = levelTime.ToString("F2");
        winTime.text = levelTime.ToString("F2");
        
    }
}