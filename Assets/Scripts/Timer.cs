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
        currentTime = isPaused ? currentTime : currentTime -= Time.deltaTime;

        if(currentTime <= timerLimit)
        {
            isPaused = true;
            pizzaManager.ResetDelivery();
            currentTime = starterTime;
        }

        timerText.text = currentTime.ToString("0.00");
    }

    public void PauseTimer(bool state)
    {
        isPaused = state;
    }
}
