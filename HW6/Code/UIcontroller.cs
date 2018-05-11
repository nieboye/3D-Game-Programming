using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour {

    private IUserAction action;
    private IScore score;

    public Transform player;            
    public float smoothing = 5f;       
    public Text s;
    public Text gg;
    public Button re;

    Vector3 offset;                    
    void Start () {
        action = SSDirector.getInstance ().currentScene as IUserAction;
        score = SSDirector.getInstance ().currentScene as IScore;
        offset = transform.position - player.position;

        re.gameObject.SetActive (false);
        Button btn = re.GetComponent<Button> ();
        btn.onClick.AddListener(restart);
    }

    void Update () {
        Vector3 playerCamPos = player.position + offset;
        transform.position = Vector3.Lerp (transform.position, playerCamPos, smoothing * Time.deltaTime);
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        move (h, v);
        turn (h, v);
        showScore ();
        gameOver ();
    }
    public void move (float h, float v) {
        action.movePlayer (h, v);
    }
    public void turn (float h, float v) {
        if (h != 0 || v != 0) 
        {
            action.setDirection (h, v);
        }
    }
    public void showScore () {
        s.text = "Score : " + score.currentScore ();
    }
    public void gameOver () {
        if (action.GameOver ()) 
        {
            if (!re.isActiveAndEnabled) 
            {
                re.gameObject.SetActive (true);
            }
            gg.text = "Game Over!";
        }
    }
    public void restart () {
        SceneManager.LoadScene ("main");
    }
}
