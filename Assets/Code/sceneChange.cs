using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
    public string gameplay;

    public void ChangeScene()
    {
        SceneManager.LoadScene(gameplay);
    }
}
