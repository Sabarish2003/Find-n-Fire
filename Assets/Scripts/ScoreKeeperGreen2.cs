using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreKeeperGreen2 : MonoBehaviour, IInputClickHandler{

    float startTime;
    ScoreManager sm;
    PlayerScript ps;
    ClosingScreenScript cs;
    ButtonDisable bs;
    
        

    void Start()
    {
        startTime = Time.realtimeSinceStartup;
        sm = GameObject.Find("ScoreBoard").GetComponent<ScoreManager>();
        ps = GameObject.Find("Player").GetComponent<PlayerScript>();
        cs = GameObject.Find("ClosingScreen").GetComponent<ClosingScreenScript>();
        bs = GameObject.Find("ClosingScreen").GetComponent<ButtonDisable>();
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        float timeDiff = Time.realtimeSinceStartup - startTime;

        if (timeDiff < 1 & timeDiff > 0)
        {
            sm.score += 500;
        }

        else if (timeDiff < 2 & timeDiff > 1)
        {
            sm.score += 450;
        }

        else if (timeDiff < 3 & timeDiff > 2)
        {
            sm.score += 400;
        }

        else if (timeDiff < 4 & timeDiff > 3)
        {
            sm.score += 350;
        }

        else if (timeDiff < 5 & timeDiff > 4)
        {
            sm.score += 300;
        }

        else if (timeDiff < 6 & timeDiff > 5)
        {
            sm.score += 250;
        }

        else if (timeDiff < 7 & timeDiff > 6)
        {
            sm.score += 200;
        }

        else if (timeDiff < 8 & timeDiff > 7)
        {
            sm.score += 150;
        }

        else if (timeDiff < 9 & timeDiff > 8)
        {
            sm.score += 100;
        }

        else if (timeDiff > 9)
        {
            sm.score += 10;
        }

        SceneManager.LoadScene("ClosingScene");

        gameObject.SetActive(false);

        //ps.Invoke("SpawnCreatureGreen2", 0);
                

    }
}
