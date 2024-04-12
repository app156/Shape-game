using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace sg
{
    public class Redtrigger : MonoBehaviour
    {
        
        [SerializeField] public float triggercount = 3;
        [SerializeField] private GameObject redmove1;
        [SerializeField] private GameObject redmove2;
        [SerializeField] private GameObject Getview;
        [SerializeField] private TextMeshProUGUI TextGetview;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if(other.tag=="Player")
            {
                Getview.SetActive(true);
            }
        }


        private void Update()
        {
            TextGetview.text= triggercount.ToString();



            if (triggercount == 0)
            {
                Getview.SetActive(false);
                redmove1.transform.rotation = Quaternion.Slerp(redmove1.transform.rotation, Quaternion.Euler(0, -90, -90.9f), 10 * Time.deltaTime);
                redmove2.transform.rotation = Quaternion.Slerp(redmove2.transform.rotation, Quaternion.Euler(0, -90, 88.6f), 10 * Time.deltaTime);

            }

        }

    }
}
