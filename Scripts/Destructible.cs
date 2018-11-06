using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour {

    public GameObject destroyedVersion;

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //other.gameObject.SetActive(false);

            

            /*count = count + 1;
            SetCountText();
            AudioSource source = GetComponent<AudioSource>();
            source.Play();*/

                       
            GameObject.FindGameObjectWithTag("Box").SetActive(false);
            Instantiate(destroyedVersion, destroyedVersion.transform.position = new Vector3(-14.58f, 0.08f, 12.127f), transform.rotation);
            //Destroy(other);

            
        }

        /*Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);*/
    }

}
