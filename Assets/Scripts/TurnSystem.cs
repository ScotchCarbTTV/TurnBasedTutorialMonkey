using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSystem : MonoBehaviour
{
    private int turnNumber = 1;

    public static TurnSystem Instance { get; private set; }

    public event EventHandler OnTurnChanged;

    private bool isPlayerTurn = true;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.Log("Only one TurnSystem should be in the scene");
            gameObject.SetActive(false);
        }
    }

    public void NextTurn()
    {
        turnNumber++;

        isPlayerTurn = !isPlayerTurn;

        OnTurnChanged?.Invoke(this, new EventArgs());
    }

    public int GetTurnNumber()
    {
        return turnNumber;
    }

    public bool IsPlayerTurn()
    {
        return isPlayerTurn;
    }
}
