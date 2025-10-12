using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneCamTransition : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
  
  }
  public void ChangeScene(string sceneName)
  {
    UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
  }
  // Update is called once per frame
}
