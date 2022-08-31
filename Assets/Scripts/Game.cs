using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject brickPrefab;
    // Start is called before the first frame update
    void Start()
    {
        float xCenter = 0;
        float y = -4.8f;
        float deltaX = 0;
        float brickWidth = brickPrefab.GetComponent<Renderer>().bounds.size.x;

        // floor
        Instantiate(brickPrefab, new Vector3(xCenter, y, 0), Quaternion.identity);
        while (deltaX < 9)
        {
            // to the right of center
            Instantiate(brickPrefab, new Vector3(xCenter + deltaX, y, 0), Quaternion.identity);
            // to the left of center
            Instantiate(brickPrefab, new Vector3(xCenter - deltaX, y, 0), Quaternion.identity);
            deltaX += brickWidth;           
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
