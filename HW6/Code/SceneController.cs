using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using com.myspace;

public class SceneController : MonoBehaviour, ISceneController, IUserAction, IScore, Handle {

    public GameObject player;

    private SSDirector director;
    private bool canOperation;
    private bool create;
    private int bearNum;
    private int ellephantNum;
    private Subject sub;
    private Animator ani;

    private Vector3 movement;  

    void Awake () {
        director = SSDirector.getInstance ();
        sub = player.GetComponent<Player> ();
        ani = player.GetComponent<Animator> ();
        director.currentScene = this;
        director.currentScene.LoadResources ();
        director.currentScene.CreatePatrols ();
        Handle sc = director.currentScene as Handle;
        sub.Attach (sc);
        GetComponent<ScoreManager> ().resetScore ();
        bearNum = 0;
        ellephantNum = 0;
        create = false;
    }

    
    public void notified(ActorState state, int pos, GameObject actor){
        if (state == ActorState.ENTER_AREA) 
        {
            record.addScore(1);
        }
        else 
            UIcontroller.loseGame();
    }
}
