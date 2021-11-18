using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCoin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Character")
        {
            other.GetComponent<PickUpCounter>().points ++;
            //Add 1 point
            Destroy(gameObject);//this destorys the item 
        }
    }
}
