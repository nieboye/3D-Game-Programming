using UnityEngine;
using System.Collections;
using MyGame;
using System.Collections.Generic;

namespace MyGame
{
    public class MyFactory: System.Object
    {
        private GameObject att = null;
        GameObject tt;
        private List<GameObject> use = new List<GameObject>();
        private List<GameObject> used = new List<GameObject>();
        private List<float> start = new List<float>();

        public MyFactory(GameObject t)
        {
            tt = t;
        }


        public void placeAttackMark(Vector3 postion)
        {
            if(used.Count == 0)
            {
                att = (GameObject)Object.Instantiate(tt, new Vector3(0, 0, 0), Quaternion.identity);
                att.transform.position = postion + new Vector3(0, 0.7f, 0);
                use.Add(att);
            }
            else
            {
                use.Add(used[0]);
                used[0].transform.position = postion + new Vector3(0, 0.7f, 0);
                used[0].SetActive(true);
                used.RemoveAt(0);
            }
            start.Add(Time.time);
            
        }

        public void disappear(int i)
        {
            use[i].SetActive(false);
            used.Add(use[i]);
            use.RemoveAt(i);
            start.RemoveAt(i);
        }

        public List<float> getStart()
        {
            return start;
        }
    }
}

public class BaseCode : MonoBehaviour {

    private GameObject cam;
    MyFactory mf;
    public GameObject go;

    // Use this for initialization
    void Start () {
        cam = GameObject.Find("Main Camera");
        mf = new MyFactory(go);
        GameObject.FindGameObjectWithTag("Attack").SetActive(false);
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("UpArrow Down！");
        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mp = Input.mousePosition; //get Screen Position

            //create ray, origin is camera, and direction to mousepoint
            Ray ray = cam.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);

            //Return the ray's hit
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                print(hit.transform.gameObject.name);
                if (hit.collider.gameObject.tag.Contains("Finish"))
                { //plane tag
                    
                    mf.placeAttackMark(hit.point); //move to here
                }
            }
        }

        for(int i = 0; i < mf.getStart().Count; i++)
        {
            if ((Time.time - mf.getStart()[i]) > 2)
                mf.disappear(i);
        }
    }
}
