using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    // Yeniden oynamak için butona komut veren scripttir.
    public void TekrarOyna()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
