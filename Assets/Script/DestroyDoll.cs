using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;

public class DestroyDoll : MonoBehaviour
{
    public int countDoll = 0;
    public TextMeshProUGUI doll;
    public GameObject winPanel;
    public GameObject healthPanel;
    public SetRecordTime RecTime;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "doll")
        {
            Destroy(other.gameObject);
            countDoll+=1;
            doll.text = countDoll.ToString()+ "/13";
            if (countDoll == 13)
            {
                winPanel.SetActive(true);
                healthPanel.SetActive(false);   
                RecTime.LevelEnded();
            }
        }
    }
    public void SetCountDoll()
    {
        countDoll = 0;
        doll.text = countDoll.ToString()+ "/13";
    }

    // Update is called once per frame
    
}