using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeLevel : MonoBehaviour
{
   public int LevelIndex;

      void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        SceneManager.LoadScene(LevelIndex);
    }

}
