using UnityEngine;

public class TurboRivalsGame : MonoBehaviour
{
    public abstract class Vehicle { }

    public class PlayerVehicle : Vehicle { }

    public class AIVehicle : Vehicle { }

    public abstract class PickupItem { }

    public class RaceManager { }

    public class ScoreManager { }


    public void StartGame() { }
    public void EndGame() { }
    public void LoadRace() { }

}
