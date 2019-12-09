using System.Collections.Generic;
using UnityEngine;

public partial class TimeManager : MonoBehaviour
{
    enum GameState
    {
        Planning,
        Simulation
    }
    GameState currentGameState;

    private int activeListeners = 0;
    private int followers = 0;
    private float governmentIntrest = 0;


    private Dictionary<Collections.TransmissionType, float> transmissionPlan;

    private List<Location> locations;

    private void Start()
    {
        currentGameState = GameState.Planning;
        locations = GatherLocations();
    }

    List<Location> GatherLocations()
    {
        throw new System.NotImplementedException();
    }
}
