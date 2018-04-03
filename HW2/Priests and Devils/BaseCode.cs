using UnityEngine;
using System.Collections;
using Com.Mygame;
using System.Collections.Generic;

namespace Com.Mygame
{
    public interface IUserActions
    {
        GameObject getBoat();
        void setpb1(GameObject p);
        void setb2(GameObject p);
        void setdb2(GameObject d);
        void setpb2(GameObject p);
        void setpb3(GameObject p);
        void setdb1(GameObject d);
        void setdb3(GameObject d);
        void removepb1(GameObject p);
        List<GameObject> getpb1();
        List<GameObject> getb2();
        List<GameObject> getpb2();
        List<GameObject> getdb2();
        List<GameObject> getpb3();
        List<GameObject> getdb3();
        List<GameObject> getdb1();
    }
    public class PADSceneController : System.Object, IUserActions
    {

        private static PADSceneController _instance;
        private BaseCode _base_code;
        private List<GameObject> pb1 = new List<GameObject>();
        private List<GameObject> db1 = new List<GameObject>();
        private List<GameObject> b2 = new List<GameObject>();
        private List<GameObject> db2 = new List<GameObject>();
        private List<GameObject> pb2 = new List<GameObject>();
        private List<GameObject> pb3 = new List<GameObject>();
        private List<GameObject> db3 = new List<GameObject>();
        private GameObject boat;

        public static string SayHello(string name)
        {
            return ("hello " + name);
        }

        public static PADSceneController GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PADSceneController();
            }
            return _instance;
        }

        public BaseCode getBaseCode()
        {
            return _base_code;
        }

        internal void setBeseCode(BaseCode bc)
        {
            if (_base_code == null)
            {
                _base_code = bc;
            }
        }
        internal void setBoat(GameObject b)
        {
            boat = b;
        }
        public GameObject getBoat()
        {
            return boat;
        }
        public void setpb1(GameObject p1)
        {
            pb1.Add(p1);
        }
        public void setdb1(GameObject d1)
        {
            db1.Add(d1);
        }
        public void setb2(GameObject p1)
        {
            b2.Add(p1);
        }
        public void setdb2(GameObject p1)
        {
            db2.Add(p1);
        }
        public void setpb2(GameObject p1)
        {
            pb2.Add(p1);
        }
        public void setpb3(GameObject p1)
        {
            pb3.Add(p1);
        }
        public void setdb3(GameObject d1)
        {
            db3.Add(d1);
        }
        public void removepb1(GameObject p1)
        {
            pb1.Remove(p1);
        }
        public void removepb3(GameObject p1)
        {
            pb3.Remove(p1);
        }
        public void removedb1(GameObject d1)
        {
            db1.Remove(d1);
        }
        public void removedb3(GameObject d1)
        {
            db3.Remove(d1);
        }
        public List<GameObject> getpb1()
        {
            return pb1;
        }
        public List<GameObject> getb2()
        {
            return b2;
        }
        public List<GameObject> getdb2()
        {
            return db2;
        }
        public List<GameObject> getpb2()
        {
            return pb2;
        }
        public List<GameObject> getpb3()
        {
            return pb3;
        }
        public List<GameObject> getdb1()
        {
            return db1;
        }
        public List<GameObject> getdb3()
        {
            return db3;
        }
    }
}

public class BaseCode : MonoBehaviour
{

    public string myName;
    public int round = 2;

    // Use this for initialization
    void Start()
    {
        PADSceneController my = PADSceneController.GetInstance();
        my.setBeseCode(this);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
