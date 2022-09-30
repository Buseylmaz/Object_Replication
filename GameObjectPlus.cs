using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectPlus : MonoBehaviour
{
    public int number;
    void Start()
    {
        StartCoroutine(PlusGameObject());
    }

    IEnumerator PlusGameObject()
    {
        for (int i = 0; i <= 10; i += 1)
        {
            number ++;

            yield return new WaitForSeconds(0.5f);
        } 
    }


    // IEnumerator:sayaçdýr
}
