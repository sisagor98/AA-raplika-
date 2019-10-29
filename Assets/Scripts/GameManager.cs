using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Rotator rotator;
    public Spaener spaener;
    private bool gameHasEnded = false;
  //  public Animator animator;

    

    void Start() {
        
    }
    public void EndGame(){
        if(gameHasEnded)
            return;    
        gameHasEnded = true;
        rotator.enabled= false;
        spaener.enabled= false;
        //animator.SetTrigger("EndGame");

    
        
    }

}
