using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class CoinCollision : MonoBehaviour
{
    [SerializeField] private UnityEvent OnCoinPicked;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnCoinPicked?.Invoke();
            Destroy(gameObject);
        }
    }
}
