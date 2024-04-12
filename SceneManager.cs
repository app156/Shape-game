using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
  public void sceneswitch(int scenenew)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scenenew);
    }
    
}
