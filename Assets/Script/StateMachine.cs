using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField] private GameObject UIGameplay;
    [SerializeField] private GameObject UIGameOver;
    public string STATE_MACHINE;
    //Menu, Play, Pause, GameOver
    void Start()
    {
        STATE_MACHINE = "Bienvenido";
    }

    void Update()
    {
        if (STATE_MACHINE == "GameOver")
        {
            UIGameplay.SetActive(false);
            UIGameOver.SetActive(true);
            STATE_MACHINE = "";
        }
    }
}
