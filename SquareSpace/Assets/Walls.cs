using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    public GameObject Wall;  // Wall Game Object.

    public bool XWall;  // Wall that moves along the X axis.
    public bool YWall;  // Wall that moves along the Y axis.
    public bool DWall;  // Wall that Disappears and Reappears whenever it pleases.

    public float WallVelocity = 5f; // Speed of Wall Movement.
    private int WallType;  // Wall Type 1 = XWall, Wall Type 2 = YWall, Wall Type 3 = DWall.

    void Start()
    {
        if (XWall)
        {
            WallType = 1;
        }
        else if (YWall)
        {
            WallType = 2;
        }
        else
        {
            WallType = 3;
        }
    }
   
    void Update()
    {
        if (WallType == 1)
        {
            XWallMovement();
        }
        else if (WallType == 2)
        {
            YWallMovement();
        }
        else
        {
            DWallToggling();
        }
    }

    void XWallMovement()
    {
        
    }

    void YWallMovement()
    {

    }

    void DWallToggling()
    {

    }

 }
