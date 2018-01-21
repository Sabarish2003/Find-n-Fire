using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoneAndSwitch : MonoBehaviour {

    ClosingScreenScript cs;
    public float time = 1;
    public string SceneName;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(SceneName);
        gameObject.SetActive(false);
        
    }
}
