using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class unloadScene : MonoBehaviour
{
    private void Awake()
    {
        SceneManager.UnloadSceneAsync("stageForest1");
        SceneManager.UnloadSceneAsync("stageForest2");
        SceneManager.UnloadSceneAsync("stageForest3");
    }
}
