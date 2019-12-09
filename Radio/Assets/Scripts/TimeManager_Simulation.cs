using UnityEngine;

public partial class TimeManager : MonoBehaviour
{
    //Specifes at what rate(in seconds) we should simulate the time
    public float tickRate = 2f;
    //How many ticks should the simulation take
    public float dayLength;
    private float nextUpdate;

    void Update()
    {
        if (currentGameState == GameState.Simulation)
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

    void UpdateMap()
    {
        foreach (Location loc in locations)
        {
            UpdateLocation(loc);
        }
    }
    void UpdateLocation(Location loc)
    {
        float newIntrest = loc.GetAuthorititesIntrest();
        if (loc.IsPlayerHere())
            newIntrest += 0.01f;
        else
            newIntrest -= 0.01f;
        loc.UpdateIntrest(newIntrest);
    }

    void EndDay()
    {
        currentGameState = GameState.Planning;
    }
}
