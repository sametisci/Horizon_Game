using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Text highScoreText;
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
        
    }

    private void Update()
    {
        //highScoreText.text = "BEST: " + PlayerController.highScore;
    }
}
