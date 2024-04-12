using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextstage : MonoBehaviour
{
    
    nexteffect nexteffect;
    [SerializeField]private int nextstageserislcount;
    [SerializeField] private GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
        nexteffect=GetComponent<nexteffect>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            UI.SetActive(false);
            nexteffect.enabled = true;

        }

    }
     public void loadNEWSTAGE()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextstageserislcount);
    }
}
