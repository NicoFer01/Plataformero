using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject UINewGame;
    [SerializeField] private GameObject UIGameplay;
    [SerializeField] private StateMachine _State;
    [SerializeField] private GameObject buttonNewGame;

    public void btnNewGame()
    {
        UINewGame.SetActive(false);
        UIGameplay.SetActive(true);
        _State.STATE_MACHINE = "Play";
    }

    public void btnGameOver()
    {
        SceneManager.LoadScene("Juego");
    }


}
