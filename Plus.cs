using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plus : MonoBehaviour
{
    
    public GameObject cube;


    void Update()
    {
        CubeNumber();
        
    }

    void CubeNumber()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int second = 0; second <= 120; second += 30)
            {
                GameObject number = Instantiate(cube);
                cube.GetComponent<MeshRenderer>().material.color = new Color(0,0,0);
            }
           
        }
       
    }

  
}
