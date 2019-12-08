using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    enum gameState
    {
        Planning,
        Simulation
    }
    gameState currentGameState = gameState.Planning;
    
    private int activeListeners = 0;
    private int followers = 0;
    private float governmentIntrest = 0;


    private Dictionary<Collections.TransmissionType, float> transmissionPlan;

    public float tickRate = 2f;
    public float dayLength;
    float nextUpdate;

    void StartSimulation()
    {
        ReadTransmissionPlan();
        ReadMapInput();
        currentGameState = gameState.Simulation;
    }

    void ReadTransmissionPlan()
    {
    }

    void ReadMapInput()
    {

    }

    void Update()
    {
        if (currentGameState == gameState.Simulation)
        {
            if (Time.time > nextUpdate)
            {
                nextUpdate = Time.time + tickRate;
                Tick();
            }
        }
    }

    void Tick()
    {
        //Update governemntIntrest
        UpdateMap();
    }

    void EndDay()
    {
        currentGameState = gameState.Planning;
    }

    void UpdateMap()
    {
        //TODO kzlakowski 
    }
}
