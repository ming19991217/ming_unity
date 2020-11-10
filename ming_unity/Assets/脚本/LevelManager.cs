using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{


   public void NextLevel(string name)
    {
        SceneManager.LoadScene("name");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("标题动画");
    }
    public void Quit()
    {
        Application.Quit();
    }


}
