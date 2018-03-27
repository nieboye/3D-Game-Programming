using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

public class Gamecontroller : MonoBehaviour
{

    private int Clicktime;
    public Text PlayerText;
    public Text WinText;
    private int[,] maze = new int[3, 3];
    private bool win;
    public Text T0;
    public Text T1;
    public Text T2;
    public Text T3;
    public Text T4;
    public Text T5;
    public Text T6;
    public Text T7;
    public Text T8;
    Button B0;
    Button B1;
    Button B2;
    Button B3;
    Button B4;
    Button B5;
    Button B6;
    Button B7;
    Button B8;
    Button RB;
    GameObject go;

    // Use this for initialization
    void Start()
    {
        Clicktime = 0;
        Clicktime = 0;
        win = false;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
                maze[i, j] = 0;
        }
        PlayerText.text = "Player:o";
        go = GameObject.FindGameObjectWithTag("Button0");
        B0 = go.GetComponent<Button>();
        go = GameObject.FindGameObjectWithTag("Button1");
        B1 = go.GetComponent<Button>();
        go = GameObject.FindGameObjectWithTag("Button2");
        B2 = go.GetComponent<Button>();
        go = GameObject.FindGameObjectWithTag("Button3");
        B3 = go.GetComponent<Button>();
        go = GameObject.FindGameObjectWithTag("Button4");
        B4 = go.GetComponent<Button>();
        go = GameObject.FindGameObjectWithTag("Button5");
        B5 = go.GetComponent<Button>();
        go = GameObject.FindGameObjectWithTag("Button6");
        B6 = go.GetComponent<Button>();
        go = GameObject.FindGameObjectWithTag("Button7");
        B7 = go.GetComponent<Button>();
        go = GameObject.FindGameObjectWithTag("Button8");
        B8 = go.GetComponent<Button>();
        go = GameObject.FindGameObjectWithTag("RButton");
        RB = go.GetComponent<Button>();
        B0.onClick.AddListener(delegate ()
        {
            if (T0.text == "")
            {
                if (Clicktime % 2 == 0)
                {
                    T0.text = "o";
                    maze[0, 0] = 1;
                }
                else
                {
                    T0.text = "x";
                    maze[0, 0] = 2;
                }
                Clicktime++;
            }
        });
        B1.onClick.AddListener(delegate ()
        {
            if (T1.text == "")
            {
                if (Clicktime % 2 == 0)
                {
                    T1.text = "o";
                    maze[0, 1] = 1;
                }
                else
                {
                    T1.text = "x";
                    maze[0, 1] = 2;
                }
                Clicktime++;
            }
        });
        B2.onClick.AddListener(delegate ()
        {
            if (T2.text == "")
            {
                if (Clicktime % 2 == 0)
                {
                    T2.text = "o";
                    maze[0, 2] = 1;
                }
                else
                {
                    T2.text = "x";
                    maze[0, 2] = 2;
                }
                Clicktime++;
            }
        });
        B3.onClick.AddListener(delegate ()
        {
            if (T3.text == "")
            {
                if (Clicktime % 2 == 0)
                {
                    T3.text = "o";
                    maze[1, 2] = 1;
                }
                else
                {
                    T3.text = "x";
                    maze[1, 2] = 2;
                }
                Clicktime++;
            }
        });
        B4.onClick.AddListener(delegate ()
        {
            if (T4.text == "")
            {
                if (Clicktime % 2 == 0)
                {
                    T4.text = "o";
                    maze[1, 1] = 1;
                }
                else
                {
                    T4.text = "x";
                    maze[1, 1] = 2;
                }
                Clicktime++;
            }
        });
        B5.onClick.AddListener(delegate ()
        {
            if (T5.text == "")
            {
                if (Clicktime % 2 == 0)
                {
                    T5.text = "o";
                    maze[1, 0] = 1;
                }
                else
                {
                    T5.text = "x";
                    maze[1, 0] = 2;
                }
                Clicktime++;
            }
        });
        B6.onClick.AddListener(delegate ()
        {
            if (T6.text == "")
            {
                if (Clicktime % 2 == 0)
                {
                    T6.text = "o";
                    maze[2, 0] = 1;
                }
                else
                {
                    T6.text = "x";
                    maze[2, 0] = 2;
                }
                Clicktime++;
            }
        });
        B7.onClick.AddListener(delegate ()
        {
            if (T7.text == "")
            {
                if (Clicktime % 2 == 0)
                {
                    T7.text = "o";
                    maze[2, 1] = 1;
                }
                else
                {
                    T7.text = "x";
                    maze[2, 1] = 2;
                }
                Clicktime++;
            }
        });
        B8.onClick.AddListener(delegate ()
        {
            if (T8.text == "")
            {
                if (Clicktime % 2 == 0)
                {
                    T8.text = "o";
                    maze[2, 2] = 1;
                }
                else
                {
                    T8.text = "x";
                    maze[2, 2] = 2;
                }
                Clicktime++;
            }
        });
        RB.onClick.AddListener(delegate ()
        {
            EditorSceneManager.LoadScene("Scene");
        });
    }



    // Update is called once per frame
    void Update()
    {
        if (Clicktime % 2 == 0)
            PlayerText.text = "Player:o";
        else
            PlayerText.text = "Player:x";
        for (int i = 0; i <= 2; i++)
        {
            if (maze[i, 0] == 1 && maze[i, 1] == 1 && maze[i, 2] == 1)
            {
                WinText.text = "o  Wins!";
                win = true;
                B0.onClick.RemoveAllListeners();
                B0.onClick.RemoveAllListeners();
                B2.onClick.RemoveAllListeners();
                B3.onClick.RemoveAllListeners();
                B4.onClick.RemoveAllListeners();
                B5.onClick.RemoveAllListeners();
                B6.onClick.RemoveAllListeners();
                B7.onClick.RemoveAllListeners();
                B8.onClick.RemoveAllListeners();
            }
            if (maze[i, 0] == 2 && maze[i, 1] == 2 && maze[i, 2] == 2)
            {
                WinText.text = "x  Wins!";
                win = true;
                B0.onClick.RemoveAllListeners();
                B0.onClick.RemoveAllListeners();
                B2.onClick.RemoveAllListeners();
                B3.onClick.RemoveAllListeners();
                B4.onClick.RemoveAllListeners();
                B5.onClick.RemoveAllListeners();
                B6.onClick.RemoveAllListeners();
                B7.onClick.RemoveAllListeners();
                B8.onClick.RemoveAllListeners();
            }
            if (maze[0, i] == 1 && maze[1, i] == 1 && maze[2, i] == 1)
            {
                WinText.text = "o  Wins!";
                win = true;
                B0.onClick.RemoveAllListeners();
                B0.onClick.RemoveAllListeners();
                B2.onClick.RemoveAllListeners();
                B3.onClick.RemoveAllListeners();
                B4.onClick.RemoveAllListeners();
                B5.onClick.RemoveAllListeners();
                B6.onClick.RemoveAllListeners();
                B7.onClick.RemoveAllListeners();
                B8.onClick.RemoveAllListeners();
            }
            if (maze[0, i] == 2 && maze[1, i] == 2 && maze[2, i] == 2)
            {
                WinText.text = "x  Wins!";
                win = true;
                B0.onClick.RemoveAllListeners();
                B0.onClick.RemoveAllListeners();
                B2.onClick.RemoveAllListeners();
                B3.onClick.RemoveAllListeners();
                B4.onClick.RemoveAllListeners();
                B5.onClick.RemoveAllListeners();
                B6.onClick.RemoveAllListeners();
                B7.onClick.RemoveAllListeners();
                B8.onClick.RemoveAllListeners();
            }
            if (maze[0, 0] == 1 && maze[1, 1] == 1 && maze[2, 2] == 1 || maze[0, 2] == 1 && maze[1, 1] == 1 && maze[2, 0] == 1)
            {
                WinText.text = "o  Wins!";
                win = true;
                B0.onClick.RemoveAllListeners();
                B0.onClick.RemoveAllListeners();
                B2.onClick.RemoveAllListeners();
                B3.onClick.RemoveAllListeners();
                B4.onClick.RemoveAllListeners();
                B5.onClick.RemoveAllListeners();
                B6.onClick.RemoveAllListeners();
                B7.onClick.RemoveAllListeners();
                B8.onClick.RemoveAllListeners();
            }
            if (maze[0, 0] == 2 && maze[1, 1] == 2 && maze[2, 2] == 2 || maze[0, 2] == 2 && maze[1, 1] == 2 && maze[2, 0] == 2)
            {
                WinText.text = "x  Wins!";
                win = true;
                B0.onClick.RemoveAllListeners();
                B0.onClick.RemoveAllListeners();
                B2.onClick.RemoveAllListeners();
                B3.onClick.RemoveAllListeners();
                B4.onClick.RemoveAllListeners();
                B5.onClick.RemoveAllListeners();
                B6.onClick.RemoveAllListeners();
                B7.onClick.RemoveAllListeners();
                B8.onClick.RemoveAllListeners();
            }
            if (Clicktime == 9 && win == false)
            {
                WinText.text = "Game is tie.";
            }
        }
    }
}
