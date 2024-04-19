using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextstage : MonoBehaviour
{
    
    nexteffect nexteffect;
   
    [SerializeField] controlplayer playercontrol;
    // Start is called before the first frame update
    void Start()
    {
        nexteffect=GetComponent<nexteffect>();
        playercontrol = UIManger.Instance.playercontrol;
    }

    // Update is called once per frame
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player"&& !UIManger.Instance.playerdie.Die)
        {

            UIManger.Instance.playerWin = true;

           
            
            
            playercontrol.enabled = false;
            nexteffect.enabled = true;


        }

    }
    
}
