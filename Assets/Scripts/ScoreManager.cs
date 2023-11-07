using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public TMP_Text textscore;
    public float score;

    void Start()
    {
        score = 0f;
        textscore.text = score.ToString() + " Crystals";
    }

   
    void Update()
    {
        textscore.text = score.ToString() + " Crystals";
    }
}
