using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;



public class die : MonoBehaviour
{

    controlplayer control;
    [SerializeField] GameObject bottomretry;
    [SerializeField] CinemachineVirtualCamera cine;
    [SerializeField] ppvignee ppcontr;
    [SerializeField] AudioSource stabvoice;
    [SerializeField] int stageidex;
    [SerializeField] GameObject UI;
    // Start is called before the first frame update


    // Update is called once per frame

    void Start()
    {
        Time.timeScale = 1;
        control = GetComponent<controlplayer>();
        

        
    }

   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "enemy")
        {
            stabvoice.Play();
            UI.SetActive(false);
            Invoke("VVOICE", 0.1f);
            Dead();
            Invoke("Stopcam", 0.2f);
            ppcontr.enabled = true;
            
        }
        if (other.name == "down")
        {
            Dead();
            Stopcam();
            ppcontr.enabled = true;
        }
    }



    public void retry()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(stageidex);
    }
    void Stopcam()
    {
        cine.enabled = false;
    }
    void Dead()
    {
        control.enabled = false;
        Invoke("bottomlate", 1);

    }

    void bottomlate()
    {
        bottomretry.SetActive(true);
    }
    void VVOICE()
    { stabvoice.enabled = false; }
}
