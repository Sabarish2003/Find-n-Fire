using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public Transform player;
    public Transform player2;
    public Transform player4;
    public Transform player6;
    public Transform player8;
    public Transform player10;
    public Transform player12;
    
    // Use this for initialization
    void Start() {
       Transform player0 = Instantiate(player, new Vector3(0, 0, 0.5f), Quaternion.Euler(0,180,0)); 
    }

    public void SpawnCreatureOrange()
    {
        Transform player1 = Instantiate(player2, new Vector3(3, 0, 1), Quaternion.Euler(0, 225, 0));
    }

    public void SpawnCreatureGreen()
    {
        Transform player3 = Instantiate(player4, new Vector3(2, 0, -0.5f), Quaternion.Euler(0, 270, 0));
    }

    public void SpawnCreatureGrey()
    {
        Transform player5 = Instantiate(player6, new Vector3(0.5f, 0, -3), Quaternion.Euler(0, 0, 0));
    }

    public void SpawnCreatureYellow()
    {
        Transform player7 = Instantiate(player8, new Vector3(3f, 0, -0.5f), Quaternion.Euler(0, 270, 0));
    }

    public void SpawnCreatureBlack2()
    {
        Transform player9 = Instantiate(player10, new Vector3(2, 0, -2), Quaternion.Euler(0, 315, 0));
    }

    public void SpawnCreatureGreen2()
    {
        Transform player11 = Instantiate(player12, new Vector3(0, 0, 1), Quaternion.Euler(0, 180, 0));
    }
}
