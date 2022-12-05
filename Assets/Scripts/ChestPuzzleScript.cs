using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestPuzzleScript : MonoBehaviour
{
    public GameObject Statue;
    public GameObject ChestOpened;
    public GameObject TextBox;
    public GameObject TextBox2;
    public bool flag = false;
    // Start is called before the first frame update
    void Start(){}
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {   
            Debug.Log("Enter");
            if (Statue.GetComponent<StatueScript>().flag == true && flag == false)
            {
                Instantiate(ChestOpened, transform.position, transform.rotation);
                Debug.Log("Chest Opened");
                GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;
                // Destroy(gameObject);
                TextBox2.SetActive(true);
                flag = true;
                // Statue.GetComponent<StatueScript>().flag = false;
            }
            else if (flag == false){
                TextBox.SetActive(true);
                Debug.Log("Chest Locked");
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Chest Exit");
            if (flag == true){
               TextBox2.SetActive(false);
            }
            else if (flag == false){
                TextBox.SetActive(false);
            }
        }
    }
    void Update()
    {
    }
}
