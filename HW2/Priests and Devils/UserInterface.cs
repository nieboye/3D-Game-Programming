using UnityEngine;
using System.Collections;
using Com.Mygame;


public class UserInterface : MonoBehaviour {

    IUserActions action = PADSceneController.GetInstance() as IUserActions;

    // Use this for initialization
    void Start () {
        
    }
	
    void OnGUI ()
    {
        if(GUI.Button(new Rect(0, 10, 100, 30), "开船"))
        {
            if(action.getb2().Count != 0)
            {
                if (action.getBoat().transform.localPosition == new Vector3(float.Parse("3.5"), -1, 0))//right
                {
                    action.getBoat().transform.localPosition = new Vector3(float.Parse("-1.5"), -1, 0);
                    if(action.getb2().Count == 1)
                    {
                        action.getb2()[0].transform.localPosition = new Vector3(float.Parse("-2.5"), float.Parse("0.5"), 0);
                    } else if(action.getb2().Count == 2) {
                        action.getb2()[0].transform.localPosition = new Vector3(float.Parse("-2.5"), float.Parse("0.5"), 0);
                        action.getb2()[1].transform.localPosition = new Vector3(float.Parse("-0.5"), float.Parse("0.5"), 0);
                    }
                }
                else//left
                {
                    action.getBoat().transform.localPosition = new Vector3(float.Parse("3.5"), -1, 0);
                    if (action.getb2().Count == 1)
                    {
                        action.getb2()[0].transform.localPosition = new Vector3(float.Parse("2.5"), float.Parse("0.5"), 0);
                    }
                    else if (action.getb2().Count == 2)
                    {
                        action.getb2()[0].transform.localPosition = new Vector3(float.Parse("2.5"), float.Parse("0.5"), 0);
                        action.getb2()[1].transform.localPosition = new Vector3(float.Parse("4.5"), float.Parse("0.5"), 0);
                    }
                }
            }
        }

        if(GUI.Button(new Rect(150, 10, 100, 30), "牧师上船"))
        {
            if(action.getb2().Count== 0)//船上没人
            {
                if(action.getBoat().transform.localPosition == new Vector3(float.Parse("3.5"), -1, 0))//船在right岸
                {
                    if(action.getpb1().Count != 0)
                    {
                        action.setb2(action.getpb1()[0]);
                        action.setpb2(action.getpb1()[0]);
                        action.getpb1()[0].transform.localPosition = new Vector3(float.Parse("2.5"), float.Parse("0.5"), 0);
                        action.getpb1().RemoveAt(0);
                    }
                } else if(action.getBoat().transform.localPosition == new Vector3(float.Parse("-1.5"), -1, 0))//船在left岸
                {
                    if (action.getpb3().Count != 0)
                    {
                        action.setb2(action.getpb3()[0]);
                        action.setpb2(action.getpb3()[0]);
                        action.getpb3()[0].transform.localPosition = new Vector3(float.Parse("-2.5"), float.Parse("0.5"), 0);
                        action.getpb3().Remove(action.getpb3()[0]);
                    }
                }
            } else if(action.getb2().Count == 1)//船上有一人
            {
                if (action.getBoat().transform.localPosition == new Vector3(float.Parse("3.5"), -1, 0))//船在right岸
                {
                    if (action.getpb1().Count != 0)
                    {
                        action.setb2(action.getpb1()[0]);
                        action.setpb2(action.getpb1()[0]);
                        action.getb2()[0].transform.localPosition = new Vector3(float.Parse("2.5"), float.Parse("0.5"), 0);
                        action.getpb1()[0].transform.localPosition = new Vector3(float.Parse("4.5"), float.Parse("0.5"), 0);
                        action.getpb1().Remove(action.getpb1()[0]);
                    }
                }
                else if (action.getBoat().transform.localPosition == new Vector3(float.Parse("-1.5"), -1, 0))//船在left岸
                {
                    if (action.getpb3().Count != 0)
                    {
                        action.setb2(action.getpb3()[0]);
                        action.setpb2(action.getpb3()[0]);
                        action.getb2()[0].transform.localPosition = new Vector3(float.Parse("-2.5"), float.Parse("0.5"), 0);
                        action.getpb3()[0].transform.localPosition = new Vector3(float.Parse("-0.5"), float.Parse("0.5"), 0);
                        action.getpb3().Remove(action.getpb3()[0]);
                    }
                }
            }
        }

        if(GUI.Button(new Rect(300, 10, 100, 30), "牧师下船"))
        {
            if(action.getpb2().Count > 0)//船上有牧师
            {
                if (action.getBoat().transform.localPosition == new Vector3(float.Parse("3.5"), -1, 0))//船在right岸
                {
                    if(action.getpb1().Count == 0)
                    {
                        action.getpb1().Insert(0, action.getpb2()[0]);
                        action.getpb2()[0].transform.localPosition = new Vector3(9, 0, 0);
                        action.getb2().Remove(action.getpb2()[0]);
                        action.getpb2().RemoveAt(0);
                    } else if(action.getpb1().Count == 1)
                    {
                        action.getpb1().Insert(0, action.getpb2()[0]);
                        action.getpb2()[0].transform.localPosition = new Vector3(float.Parse("7.5"), 0, 0);
                        action.getb2().Remove(action.getpb2()[0]);
                        action.getpb2().RemoveAt(0);
                    } else if(action.getpb1().Count == 2)
                    {
                        action.getpb1().Insert(0, action.getpb2()[0]);
                        action.getpb2()[0].transform.localPosition = new Vector3(6, 0, 0);
                        action.getb2().Remove(action.getpb2()[0]);
                        action.getpb2().RemoveAt(0);
                    }
                }  else if (action.getBoat().transform.localPosition == new Vector3(float.Parse("-1.5"), -1, 0))//船在left岸
                {
                    if (action.getpb3().Count == 0)
                    {
                        action.getpb3().Insert(0, action.getpb2()[0]);
                        action.getpb2()[0].transform.localPosition = new Vector3(-6, 0, 0);
                        action.getb2().Remove(action.getpb2()[0]);
                        action.getpb2().RemoveAt(0);
                    }
                    else if (action.getpb3().Count == 1)
                    {
                        action.getpb3().Insert(0, action.getpb2()[0]);
                        action.getpb2()[0].transform.localPosition = new Vector3(float.Parse("-4.5"), 0, 0);
                        action.getb2().Remove(action.getpb2()[0]);
                        action.getpb2().RemoveAt(0);
                    }
                    else if (action.getpb3().Count == 2)
                    {
                        action.getpb3().Insert(0, action.getpb2()[0]);
                        action.getpb2()[0].transform.localPosition = new Vector3(-3, 0, 0);
                        action.getb2().Remove(action.getpb2()[0]);
                        action.getpb2().RemoveAt(0);
                    }
                }
            }
        }

        if(GUI.Button(new Rect(450, 10, 100, 30), "恶魔上船"))
        {
            if (action.getb2().Count  == 0)//船上没人
            {
                if (action.getBoat().transform.localPosition == new Vector3(float.Parse("3.5"), -1, 0))//船在right岸
                {
                    if (action.getdb1().Count != 0)
                    {
                        action.setb2(action.getdb1()[0]);
                        action.setdb2(action.getdb1()[0]);
                        action.getdb1()[0].transform.localPosition = new Vector3(float.Parse("2.5"), float.Parse("0.5"), 0);
                        action.getdb1().RemoveAt(0);
                    }
                }
                else if (action.getBoat().transform.localPosition == new Vector3(float.Parse("-1.5"), -1, 0))//船在left岸
                {
                    if (action.getdb3().Count != 0)
                    {
                        action.setb2(action.getdb3()[0]);
                        action.setdb2(action.getdb3()[0]);
                        action.getdb3()[0].transform.localPosition = new Vector3(float.Parse("-2.5"), float.Parse("0.5"), 0);
                        action.getdb3().Remove(action.getdb3()[0]);
                    }
                }
            }
            else if (action.getb2().Count == 1)//船上有一人
            {
                if (action.getBoat().transform.localPosition == new Vector3(float.Parse("3.5"), -1, 0))//船在right岸
                {
                    if (action.getdb1().Count != 0)
                    {
                        action.setb2(action.getdb1()[0]);
                        action.setdb2(action.getdb1()[0]);
                        action.getb2()[0].transform.localPosition = new Vector3(float.Parse("2.5"), float.Parse("0.5"), 0);
                        action.getdb1()[0].transform.localPosition = new Vector3(float.Parse("4.5"), float.Parse("0.5"), 0);
                        action.getdb1().Remove(action.getdb1()[0]);
                    }
                }
                else if (action.getBoat().transform.localPosition == new Vector3(float.Parse("-1.5"), -1, 0))//船在left岸
                {
                    if (action.getdb3().Count != 0)
                    {
                        action.setb2(action.getdb3()[0]);
                        action.setdb2(action.getdb3()[0]);
                        action.getb2()[0].transform.localPosition = new Vector3(float.Parse("-2.5"), float.Parse("0.5"), 0);
                        action.getdb3()[0].transform.localPosition = new Vector3(float.Parse("-0.5"), float.Parse("0.5"), 0);
                        action.getdb3().Remove(action.getdb3()[0]);
                    }
                }
            }
        }

        if(GUI.Button(new Rect(600, 10, 100, 30), "恶魔下船"))
        {
            if (action.getdb2().Count > 0)//船上有恶魔
            {
                if (action.getBoat().transform.localPosition == new Vector3(float.Parse("3.5"), -1, 0))//船在right岸
                {
                    if (action.getdb1().Count == 0)
                    {
                        action.getdb1().Insert(0, action.getdb2()[0]);
                        action.getdb2()[0].transform.localPosition = new Vector3(float.Parse("13.5"), float.Parse("-0.5"), 0);
                        action.getb2().Remove(action.getdb2()[0]);
                        action.getdb2().RemoveAt(0);
                    }
                    else if (action.getdb1().Count == 1)
                    {
                        action.getdb1().Insert(0, action.getdb2()[0]);
                        action.getdb2()[0].transform.localPosition = new Vector3(float.Parse("12"), float.Parse("-0.5"), 0);
                        action.getb2().Remove(action.getdb2()[0]);
                        action.getdb2().RemoveAt(0);
                    }
                    else if (action.getdb1().Count == 2)
                    {
                        action.getdb1().Insert(0, action.getdb2()[0]);
                        action.getdb2()[0].transform.localPosition = new Vector3(float.Parse("10.5"), float.Parse("-0.5"), 0);
                        action.getb2().Remove(action.getdb2()[0]);
                        action.getdb2().RemoveAt(0);
                    }
                }
                else if (action.getBoat().transform.localPosition == new Vector3(float.Parse("-1.5"), -1, 0))//船在left岸
                {
                    if (action.getdb3().Count == 0)
                    {
                        action.getdb3().Insert(0, action.getdb2()[0]);
                        action.getdb2()[0].transform.localPosition = new Vector3(float.Parse("-10.5"), 0, 0);
                        action.getb2().Remove(action.getdb2()[0]);
                        action.getdb2().RemoveAt(0);
                    }
                    else if (action.getdb3().Count == 1)
                    {
                        action.getdb3().Insert(0, action.getdb2()[0]);
                        action.getdb2()[0].transform.localPosition = new Vector3(-9, 0, 0);
                        action.getb2().Remove(action.getdb2()[0]);
                        action.getdb2().RemoveAt(0);
                    }
                    else if (action.getdb3().Count == 2)
                    {
                        action.getdb3().Insert(0, action.getdb2()[0]);
                        action.getdb2()[0].transform.localPosition = new Vector3(float.Parse("-7.5"), 0, 0);
                        action.getb2().Remove(action.getdb2()[0]);
                        action.getdb2().RemoveAt(0);
                    }
                }
            }
        }
    }

	// Update is called once per frame
	void Update () {
	    if(action.getdb3().Count == 3 && action.getpb3().Count == 3)
        {
            Application.LoadLevel("Win");
        }
        if (action.getBoat().transform.localPosition == new Vector3(float.Parse("-1.5"), -1, 0))//船在left岸
        {
            if (action.getdb3().Count + action.getdb2().Count > action.getpb2().Count + action.getpb3().Count)
                Application.LoadLevel("Lose");
        }
        if (action.getBoat().transform.localPosition == new Vector3(float.Parse("3.5"), -1, 0))//船在right岸
        {
            if (action.getdb1().Count + action.getdb2().Count > action.getpb2().Count + action.getpb1().Count)
                Application.LoadLevel("Lose");
        }
    }
}
