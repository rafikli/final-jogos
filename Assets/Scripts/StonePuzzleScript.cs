using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StonePuzzleScript : MonoBehaviour
{
    public GameObject RedBox;
    public GameObject GreenBox;
    public GameObject BlueBox;
    public GameObject DoorOpened;
        
    // Start is called before the first frame update
    void Start() {}
    // Update is called once per frame
    void Update()
    {
        if (RedBox.GetComponent<REDStonePuzzleScript>().flag == true && GreenBox.GetComponent<GREENStonePuzzleScript>().flag == true && BlueBox.GetComponent<BLUEStonePuzzleScript>().flag == true)
        {
            Instantiate(DoorOpened, transform.position, transform.rotation);
            Destroy(gameObject);
        }

    }
}
