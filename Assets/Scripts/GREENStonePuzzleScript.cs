using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GREENStonePuzzleScript : MonoBehaviour
{
    public bool flag = false;
    private void OnTriggerStay2D(Collider2D other)
        {
            if(other.gameObject.tag == "GREEN"){
                flag = true;
                // Debug.Log(other.gameObject.tag);
            }
            else{
                flag = false;
            }
        }
}
