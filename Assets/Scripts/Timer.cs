using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [Header("Component")]
    [SerializeField] private TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    [SerializeField] private bool isPaused;
    [SerializeField] private float timerLimit;
    [SerializeField] private float starterTime;
    private float minutes = 0f;
    private float seconds = 0f;

    private float currentTime;

    [Header("Pizza Manager")]
    [SerializeField] private PizzaManager pizzaManager;

    void Awake()
    {
        isPaused = true;
    }

    void Start()
    {
        pizzaManager = FindAnyObjectByType<PizzaManager>();
        currentTime = starterTime;
    }

    void Update()
    {
        if(currentTime <= timerLimit)
        {
            isPaused = true;
            pizzaManager.ResetDelivery();
            currentTime = starterTime;
        }

        currentTime = isPaused ? currentTime : currentTime -= Time.deltaTime;

        minutes = Mathf.FloorToInt(currentTime / 60);
        seconds = Mathf.FloorToInt(currentTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);;
    }

    public void PauseTimer(bool state)
    {
        isPaused = state;
    }

    public void AddTime(float time)
    {
        currentTime += time;
    }
}
