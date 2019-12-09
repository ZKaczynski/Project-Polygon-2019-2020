using UnityEngine;

public partial class TimeManager : MonoBehaviour
{
    void StartSimulation()
    {
        ReadTransmissionPlan();
        ReadMapInput();
        currentGameState = GameState.Simulation;
    }

    void ReadTransmissionPlan()
    {
    }

    void ReadMapInput()
    {

    }
}
