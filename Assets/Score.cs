using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int score;

    public void ScoreUpdate(int value)
    {
        score = score + value;
        Debug.Log("Score :" + score);
    }


}
