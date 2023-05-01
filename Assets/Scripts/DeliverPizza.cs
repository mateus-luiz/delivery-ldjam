using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverPizza : MonoBehaviour
{
    private PizzaManager pizzaManager;

    [Header("Timer Settings")]
    [SerializeField] private Timer timer;

    [Header("Score Settings")]
    [SerializeField] private ScoreManager scoreManager;

    [Header("AudioSource")]
    private AudioSource audioSource;
    public AudioClip audioClip;

    void Start() 
    {
        pizzaManager = FindFirstObjectByType<PizzaManager>();
        timer = FindFirstObjectByType<Timer>();
        scoreManager = FindFirstObjectByType<ScoreManager>();
        audioSource = FindFirstObjectByType<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Motorcycle"))
        {
            Delivery();
        }
    }

    public void Delivery()
    {
        int amountPizza = pizzaManager.GetAmountPizza();
        pizzaManager.SetAmountPizza(--amountPizza);
        
        if(amountPizza >= 1)
        {
            pizzaManager.SpawnDeliveryPoint();
        }
        
        if(amountPizza <= 0)
        {   
            timer.PauseTimer(true);
            pizzaManager.EnableAllRefillPoint();
        }
        
        scoreManager.IncreaseScore();
        timer.AddTime(5f);
        audioSource.PlayOneShot(audioClip);

        Destroy(this.gameObject);
    }
}
