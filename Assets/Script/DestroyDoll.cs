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
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "doll")
        {
            Destroy(other.gameObject);
            countDoll+=1;
            doll.text = countDoll.ToString()+ "/13";
        }
    }
    public void SetCountDoll()
    {
        countDoll = 0;
    }

    // Update is called once per frame
    
}