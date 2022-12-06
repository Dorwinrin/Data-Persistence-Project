using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject playerNameInput;

    public void SetPlayerName(string playerName)
    {
        PersistenceManager.Instance.playerName = playerName;
        Debug.Log(PersistenceManager.Instance.playerName);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void StartGame()
    {
        if (PersistenceManager.Instance.playerName != "")
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            playerNameInput.GetComponent<Image>().color = Color.yellow;
        }
    }
}
