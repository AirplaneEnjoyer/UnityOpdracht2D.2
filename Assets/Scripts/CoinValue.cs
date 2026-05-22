using UnityEngine;

public class CoinValue : MonoBehaviour
{
    [SerializeField] private int _ScoreWorth;

    public int GetScoreWorth()
    {
        return _ScoreWorth;
    }

}
