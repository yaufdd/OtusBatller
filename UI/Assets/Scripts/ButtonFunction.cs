using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ButtonFunction : MonoBehaviour
{
    public CanvasGroup afterPauseBtns;
    public CanvasGroup pauseBtn;


    void Start()
    {

        afterPauseBtns.alpha = 0;
        afterPauseBtns.blocksRaycasts = false;
        afterPauseBtns.interactable = false;

        Countinue();
    }

    public void Pause()
    {
        pauseBtn.alpha = 0;
        pauseBtn.blocksRaycasts = false;
        pauseBtn.interactable = false;

        afterPauseBtns.alpha = 1;
        afterPauseBtns.blocksRaycasts = true;
        afterPauseBtns.interactable = true;

    }

    public void Countinue()
    {
        pauseBtn.alpha = 1;
        pauseBtn.blocksRaycasts = true;
        pauseBtn.interactable = true;

        afterPauseBtns.alpha = 0;
        afterPauseBtns.blocksRaycasts = false;
        afterPauseBtns.interactable = false;
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("menu");
    }

   

}
