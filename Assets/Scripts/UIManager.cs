using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void SetPlayerName(string playerName)
    {
        PersistenceManager.Instance.playerName = playerName;
        Debug.Log(PersistenceManager.Instance.playerName);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
