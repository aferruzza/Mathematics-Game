using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayFromMain : MonoBehaviour
{
    // Start is called before the first frame update
    public void load()
    {
        SceneManager.LoadScene(1);
    }
}
