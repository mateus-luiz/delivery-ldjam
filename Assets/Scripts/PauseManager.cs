using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    private MotorcycleActions actions;

    [SerializeField] private GameObject[] UIElements;
    [SerializeField] private GameObject pausePanel;

    private bool isGamePaused = false;

    void Awake()
    {
        actions = new MotorcycleActions();
    }

    void Start()
    {
        pausePanel.SetActive(false);
    }
    void Update()
    {
        actions.MotorcycleInputs.PauseGame.performed += _ => PauseGame();
    }

    void OnEnable()
    {
        actions.Enable();
    }
    void OnDisable()
    {
        actions.Enable();
    }

    void PauseGame()
    {
        isGamePaused = !isGamePaused;
        Debug.Log("Pause");

        pausePanel.SetActive(isGamePaused);

        if (isGamePaused)
        {
            Time.timeScale = 0;
            foreach (GameObject element in UIElements)
            {
                element.SetActive(false);
            }
        }
        else
        {
            Time.timeScale = 1;
            foreach (GameObject element in UIElements)
            {
                element.SetActive(true);
            }
        }
    }
}
