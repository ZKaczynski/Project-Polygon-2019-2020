public class Location
{
    Location(string name)
    {
        this.name = name;
    }
    string name;
    float authoritiesIntrest = 0;
    bool playerIsHere = false;

    public void UpdateIntrest(float authoritiesIntrest)
    {
        this.authoritiesIntrest = authoritiesIntrest;
    }

    public float GetAuthorititesIntrest()
    {
        return authoritiesIntrest;
    }

    public bool IsPlayerHere() { return playerIsHere; }

    public void AddPlayer() => playerIsHere = true;

    public void RemovePlayer() => playerIsHere = false;
}
