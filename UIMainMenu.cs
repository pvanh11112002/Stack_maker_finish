using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private GameObject gameManagerObject;
    // Start is called before the first frame update
    //void Start()
    //{
    //    playButton.onClick.AddListener(() => Play());
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play()
    {
        gameManagerObject.SetActive(true);
        gameObject.SetActive(false);
    }
}
