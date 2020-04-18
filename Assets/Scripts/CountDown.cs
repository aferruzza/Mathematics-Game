using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    public float timePerLevel;
    public Text text;
    
    void Update()
    {
        timePerLevel -= Time.deltaTime;
        text.text = "Time Remaining : " + Mathf.Round(timePerLevel);
        if (timePerLevel < 0)
        {
            SceneManager.LoadScene("YouLost");
        }
    }

}
