using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Sceneloader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadSceneNext(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    
    }
    public void Exit()
    {
        Application.Quit();
    }

}
