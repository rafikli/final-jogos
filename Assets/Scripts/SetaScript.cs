using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetaScript : MonoBehaviour
{

    public GameObject TextBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            TextBox.SetActive(true);
            Debug.Log("Seta In");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            TextBox.SetActive(false);
            Debug.Log("Seta Out");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
