using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void startGame()
    {
        print("開始");

        SceneManager.LoadScene("SampleScene");
    }
    public  void quitGame()
    {
        print("結束");
        Application.Quit();
    }
}
