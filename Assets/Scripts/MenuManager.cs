using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject startPannel;
    [SerializeField] private GameObject scorePannel;
    [SerializeField] private GameObject resultPannel;
    [SerializeField] private Button gameButton;

    private void Start()
    {
        EggLife.Instance.GameOver += gameOver;
    }

    public void StartButton()
    {
        scorePannel.gameObject.SetActive(true);
        gameButton.gameObject.SetActive(true);
        startPannel.gameObject.SetActive(false);
    }

    public void HomeButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    private void gameOver()
    {
        resultPannel.gameObject.SetActive(true);
    }

    private void OnDisable()
    {
        EggLife.Instance.GameOver -= gameOver;
    }
}
