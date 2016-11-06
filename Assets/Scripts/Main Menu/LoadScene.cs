using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public int sceneIndex = 1;

    public void Load()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
