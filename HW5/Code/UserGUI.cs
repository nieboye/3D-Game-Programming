using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Com.Mygame;

public class UserGUI : MonoBehaviour
{
    private IUserAction action;
    bool isFirst = true;
    // Use this for initialization  
    void Awake()
    {
        action = Director.getInstance().sceneController as IUserAction;
        isFirst = true;
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(800, 10, 300, 300), "Rule:\nWhite Disk:1 point\nYellow Disk:2 point" +
            "\nRed Disk:3 point" +
            "\nFirst target: 5\nSecond target: 15\nFinal target: 30");
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 pos = Input.mousePosition;
            action.hit(pos);
        }
        GUI.Label(new Rect(200, 10, 300, 300), "Score : "+ action.GetScore().ToString());
        if (isFirst && GUI.Button(new Rect(350, 140, 100, 100), "Start"))
        {
            isFirst = false;
            action.setGameState(GameState.ROUND_START);
        }
        if (!isFirst && action.getGameState() == GameState.ROUND_FINISH && GUI.Button(new Rect(350, 140, 100, 100), "Next Round"))
        {
            action.setGameState(GameState.ROUND_START);
        }
        if(action.getGameState() == GameState.GAME_OVER)
        {
            GUI.Label(new Rect(366, 330, 90, 90), "GAMEOVER!");
            if (GUI.Button(new Rect(350, 140, 100, 100), "ReStart"))
            {
                isFirst = false;
                action.setGameState(GameState.ROUND_START);
            }
        }
        if (action.getGameState() == GameState.WIN)
        {
            GUI.Label(new Rect(366, 330, 90, 90), "YOU WIN!");
            if (GUI.Button(new Rect(350, 140, 100, 100), "ReStart"))
            {
                isFirst = false;
                action.setGameState(GameState.ROUND_START);
            }
        }
    }
}