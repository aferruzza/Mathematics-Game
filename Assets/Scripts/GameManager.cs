using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;
    public string[] AnswersArray;
    public int index;
    public Text youWin;
    
    
    // Start is called before the first frame update
    void Start()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        instance = this;
        youWin.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (index == AnswersArray.Length)
        {
            if (SceneManager.GetActiveScene().buildIndex <= 17)
            {
                
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                SceneManager.LoadScene("Endgame");
            }
        }
    }

}
