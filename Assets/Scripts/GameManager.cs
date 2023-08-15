using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserData
{
    public int Score;
    public int BestScore;
    public int Coin;
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public UserData userData;
    public bool IsBirdDie = false;
    private void Awake()
    {
        Instance = this;
        userData = new UserData();
    }

    public bool IsEndGame()
    {
        return IsBirdDie;
    }

    public void EndGame()
    {
        if (IsBirdDie == false)
        {
            AudioManager.Instance.PlayAudioDie();
        }
        IsBirdDie = true;
    }
    public void AddScore()
    {
        userData.Score++;
        AudioManager.Instance.PlayAudioAddScore();
    }
}

