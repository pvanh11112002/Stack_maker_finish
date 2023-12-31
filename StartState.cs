﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartState : BaseStateMachine/*, MonoBehaviour*/
{
    //public int mapIndex = 0;
    public TextAsset maptext;
    //public TextAsset maptext;
    public GameObject brickStartPrefabs;
    public GameObject brickFinishPrefabs;
    public GameObject brickPrefabs;
    public GameObject brickLostPrefabs;
    public GameObject brickPrefabWithoutCollider;
    public GameObject playerPrefabs;
    
    
    //Gen Map và đưa player về start points
    public override void Enter(GameManager gameManager)
    {
        maptext = LevelController.Instance.map[LevelController.Instance.level - 1];
        
        string data = maptext.text;
        string[] data2 = data.Split("\r\n");
        int row = data2.Length;
        int col = data2[0].Split(",").Length;
        Debug.Log("Row: " + row);
        Debug.Log("Col: " + col);
        int[,] map = new int[row, col];
        for (int i = 0; i < row; i++)
        {
            if (data2.Length > 0)
            {
                string[] tmp = data2[i].Split(",");
                for (int j = 0; j < tmp.Length; j++)
                {
                    map[i, j] = int.Parse(tmp[j]);
                }
            }
        }
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                // Trong môi trường 3D, thay x  = j, y = 0, z = i.
                if (map[i, j] == 4) // Điểm khởi đầu có giá trị bằng 4, màu xám
                {
                    GameObject newPlayer = Instantiate(playerPrefabs, new Vector3(i, 1, j), Quaternion.identity);
                    GameObject newBricks = Instantiate(brickStartPrefabs, new Vector3(j, 0, i), Quaternion.identity);
                    newBricks.GetComponent<MeshRenderer>().material.color = Color.grey;
                }
                if (map[i, j] == -4) // Đích có giá trị bằng -4, màu xanh lá cây
                {
                    GameObject newBricks = Instantiate(brickFinishPrefabs, new Vector3(j, 0, i), Quaternion.identity);
                    newBricks.GetComponent<MeshRenderer>().material.color = Color.green;
                }

                // Nếu giá trị của map[i,j] = -1 thì ra màu vàng, nếu = 1 thì ra màu đỏ
                if (map[i, j] == -1)
                {
                    GameObject newBricks = Instantiate(brickLostPrefabs, new Vector3(j, 0, i), Quaternion.identity);
                    newBricks.GetComponent<MeshRenderer>().material.color = Color.yellow;
                }
                if (map[i, j] == 1)
                {
                    GameObject newBricks = Instantiate(brickPrefabs, new Vector3(j, 0, i), Quaternion.identity);
                    newBricks.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    Instantiate(brickPrefabWithoutCollider, new Vector3(j, 0, i), Quaternion.identity);
                }
            }
        }
        // Sau khi ren map xong thì đổi sang play state
        gameManager.SwitchState(gameManager.PlayS);
    }

    public override void Excute(GameManager gameManager)
    {
                   
    }
    public override void OnCollisionEnter(Collision collision)
    {
        throw new System.NotImplementedException();
    }
}
