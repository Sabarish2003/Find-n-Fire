using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public int score;        // The player's score.


    public TextMesh ScoreBoard;                     // Reference to the Text component.


    void Awake()
    {
        // Set up the reference.
        ScoreBoard = GetComponent<TextMesh>();

        // Reset the score.
        score = 0;
    }


    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        ScoreBoard.text = "Score: " + score;
    }

    
}