using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
private const int SIZE = 4;   

[SerializeField] 
private Cell cellPrefab;

private Cell [,] table;
private void Clear()
{
     Cell cells = GetComponent<Cell>();
     
        while(cells !=null)
            Destroy(cells.gameObject);

    table = new Cell[SIZE, SIZE];
}

    void Start()
    {
      

    }

}
