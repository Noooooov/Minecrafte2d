using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    private Image Batonimage;
    public Color colact;
    public Color colneg;
    private GameObject Spawned;
    private Grid grid;
    private void Start()
    {
        grid = FindFirstObjectByType<Grid>();
    }
    public void spawner(GameObject prefab)
    {
        Spawned = prefab;
    }
    public void click(Image batonimage)
    {
        if (Batonimage == batonimage) 
        {
            Spawned = null;
            Batonimage.color = colneg;
            Batonimage = null;
        }
        else if (Batonimage == null) 
        {
            Batonimage = batonimage;
            Batonimage.color = colact;
        }
        else 
        {
            Batonimage.color = colneg;
            Batonimage = batonimage;
            Batonimage.color = colact;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Spawned != null) 
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int cell = grid.WorldToCell(pos);
            Vector3 centercell = grid.GetCellCenterWorld(cell);
            Instantiate(Spawned, centercell, Spawned.transform.rotation);
        }
    }
}
