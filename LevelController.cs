using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    private static LevelController instance;
    public static LevelController Instance { get { return instance; } }
    #region Another way of singleton
    //{
    //    get
    //    {
    //        if(instance == null)
    //        {
    //            instance = FindObjectOfType<LevelController>();
    //        }
    //        return instance;
    //    }
    //}
    #endregion
    private void Awake()
    {       
        instance = this;
    }
    public TextAsset[] map;
    public int level;
    //Map[level]?
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
