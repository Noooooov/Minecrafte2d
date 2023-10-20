using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class ZamokZamka : MonoBehaviour
{
    private Button boo;
    public int lid;
    public GameObject zamok;
    void Start()
    {
        boo = GetComponent<Button>();
        if (YandexGame.savesData.Progress < lid)
        {
            boo.interactable = false;
            zamok.SetActive(true);
        }
    }

    void Update()
    {
        
    }
}
