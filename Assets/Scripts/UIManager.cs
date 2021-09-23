using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{

   
 
    void OnStartButtonClick()
    {
        SceneManager.LoadScene(1);

    }

    public void GetName(string s)
    {
        DataManager.Instance.playerName = s;
        Debug.Log(DataManager.Instance.playerName);
    }
}
