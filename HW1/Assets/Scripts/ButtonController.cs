using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEditor.SceneManagement;

public class ButtonController : MonoBehaviour
{

    GameObject go;
    Button sb;
    // Use this for initialization
    void Start()
    {
        go = GameObject.FindGameObjectWithTag("SButton");
        sb = go.GetComponent<Button>();
        sb.onClick.AddListener(delegate ()
        {
            EditorSceneManager.LoadScene("Scene");
        });
    }

    // Update is called once per frame
    void Update()
    {

    }
}
