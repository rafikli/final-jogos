using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Audio;

public class StatueScript : MonoBehaviour
{
    public AudioClip heaven;
    public GameObject TextBox;
    public bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource> ().playOnAwake = false;
        GetComponent<AudioSource> ().clip = heaven;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {   
            flag = true;
            TextBox.SetActive(true);
            GetComponent<AudioSource> ().Play ();   
            Debug.Log("Enter");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            TextBox.SetActive(false);
            // GetComponent<AudioSource> ().Stop ();
            Debug.Log("Exit");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
