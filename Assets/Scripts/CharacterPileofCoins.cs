using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPileofCoins : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Character")
        {
            other.GetComponent<PickUpCounter>().points += 10;
            //Add 1 point
            Destroy(gameObject);//this destorys the item 
        }
    }
}
