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
        if (YG2.saves.Progress < lid)
        {
            boo.interactable = false;
            zamok.SetActive(true);
        }
    }
}
