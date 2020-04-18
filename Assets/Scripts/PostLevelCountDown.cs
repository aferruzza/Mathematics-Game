using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PostLevelCountDown : MonoBehaviour
{
    public float timePerLevel;
    public Text text;

    void Update()
    {
        timePerLevel -= Time.deltaTime;
        text.text = "Next Wave Begins : " + Mathf.Round(timePerLevel);
        if (timePerLevel < 0)
        {
            SceneManager.LoadScene("Level6");
        }
    }

}
