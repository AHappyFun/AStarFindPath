using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public AStar Astarpath;

    public int Height = 4;
    public int Width = 4;
    public Node[,] nodes;
   
    
    void Start()
    {
        InitMap();
        StartFindPath();
    }

    void InitMap()
    {
        nodes = new Node[Width, Height];
        for (int i = 0; i < Width; i++)
        {
            for (int j = 0; j < Height; j++)
            {
                nodes[i, j] = new Node(i, j);
            }
        }
        //nodes[4, 4].SetIsWall(true);
        //nodes[5, 4].SetIsWall(true);
        //nodes[6, 4].SetIsWall(true);
        nodes[1, 1].SetIsWall(true);
        nodes[2, 3].SetIsWall(true);
    }

    void StartFindPath()
    {
        //Astarpath.AStarPath(nodes[3,2], nodes[8,8]);
        //ShowPath(nodes[8,8]);

        Astarpath.AStarPath(nodes[0, 2], nodes[3, 0]);
        ShowPath(nodes[3, 0]);
    }

    void ShowPath(Node end)
    {
        end.ShowPathNode();
    }
}
