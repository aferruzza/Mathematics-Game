using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    
    public Button btn;
    
    public void clicked()
    {
        if (btn.GetComponentInChildren<Text>().text.Equals(GameManager.instance.AnswersArray[GameManager.instance.index]))
        {
            btn.GetComponent<Image>().color = new Color(0, 128, 0, 210);
            GameManager.instance.index += 1;
        }
        
    }
}
