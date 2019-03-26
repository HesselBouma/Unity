using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public Animator WallAnimation;

    private void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("raak");
            WallAnimation.enabled = true;
        }
    }


}
