using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generowanie : MonoBehaviour
{


    [SerializeField]
    private GameObject prefab;


    // Start is called before the first frame update
    void Start()
    {
        const float gridSpacing = 11;
        const int gridSize = 20;
        for(int x = 0; x < gridSize; x++)
        {
            for(int z = 0; z< gridSize; z++)
            {
                Instantiate(prefab, new Vector3(x*gridSpacing, 0.1f, z*gridSpacing), Quaternion.identity );
            }
        }
      
        
    }

   
}
