using System.Collections;
using System.Collections.Generic;

using UnityEngine;


public class controlplayer : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D playerrigidbody;
    private controlplayer control;
    private bool forword=false;
    private bool back = false;
    private bool zoominc = false;
    private bool zoomoutc = false;


    void Start()
    {
        playerrigidbody = GetComponent<Rigidbody2D>();
        control = GetComponent<controlplayer>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.D) || forword)
        {
            playerrigidbody.AddTorque(-15 * Time.deltaTime, ForceMode2D.Impulse);
           


        }
        if (Input.GetKey(KeyCode.A)||back)
        {
            playerrigidbody.AddTorque(15 * Time.deltaTime, ForceMode2D.Impulse);

         
        }
        if (Input.GetKey(KeyCode.W) ||   zoomoutc)
        {
           
            transform.localScale += new Vector3(1, 0, 0) * 2 * Time.deltaTime;
            if (transform.localScale.x > 6)
            {
                transform.localScale = new Vector3(6, 1, 1);
            }
           
        }

        if (Input.GetKey(KeyCode.S)|| zoominc)
        {
        
            transform.localScale += new Vector3(-1, 0, 0) * 2 * Time.deltaTime;
            if (transform.localScale.x < 0.1)
            {
                transform.localScale = new Vector3(0.1f, 1, 1);
            }
            
        }

    }

    public void rollForward()
    {
        forword = true;
    }
    public void nonrollForward()
    {
        forword = false;
    }
    public void rollback()
    {
        back=true;
    }
    public void nonrollback()
    {
        back = false;
    }
    public void zoomin()
    {
        zoominc = true;
    }
    public void nonzoomin()
    {
        zoominc = false;
    }
    public void zoomout()
    {
        zoomoutc = true;
    }
    public void nonzoomout()
    {
        zoomoutc = false;
    }
}

    




