using UnityEngine;
using System.Collections;
using Com.Mygame;


public class GenGameObjects : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GameObject P1 = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        P1.transform.position = new Vector3(6, 0, 0);
        GameObject P2 = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        P2.transform.position = new Vector3(float.Parse("7.5"), 0, 0);
        GameObject P3 = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        P3.transform.position = new Vector3(9, 0, 0);
        GameObject D1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        D1.transform.position = new Vector3(float.Parse("10.5"), float.Parse("-0.5"), 0);
        D1.GetComponent<Renderer>().material.color = Color.black;
        GameObject D2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        D2.transform.position = new Vector3(12, float.Parse("-0.5"), 0);
        D2.GetComponent<Renderer>().material.color = Color.black;
        GameObject D3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        D3.transform.position = new Vector3(float.Parse("13.5"), float.Parse("-0.5"), 0);
        D3.GetComponent<Renderer>().material.color = Color.black;
        GameObject Bank1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Bank1.transform.position = new Vector3(10, float.Parse("-1.5"), 0);
        Bank1.transform.localScale = new Vector3(10, 1, 1);
        GameObject River = GameObject.CreatePrimitive(PrimitiveType.Cube);
        River.transform.position = new Vector3(1, float.Parse("-1.75"), 0);
        River.transform.localScale = new Vector3(8, float.Parse("0.5"), 1);
        GameObject Bank2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Bank2.transform.position = new Vector3(-8, float.Parse("-1.5"), 0);
        Bank2.transform.localScale = new Vector3(10, 1, 1);
        GameObject Boat = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Boat.GetComponent<Renderer>().material.color = Color.blue;
        Boat.transform.position = new Vector3(float.Parse("3.5"), -1, 0);
        Boat.transform.localScale = new Vector3(3, 1, 1);
        PADSceneController PAD = PADSceneController.GetInstance();
        PAD.setBoat(Boat);
        PAD.setpb1(P1);
        PAD.setpb1(P2);
        PAD.setpb1(P3);
        PAD.setdb1(D1);
        PAD.setdb1(D2);
        PAD.setdb1(D3);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
