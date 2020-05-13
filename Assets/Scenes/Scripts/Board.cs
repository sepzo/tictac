using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{   

    public GameObject mCellPrefab;
    private Cell[] mCells = new Cell[9];

    void Start()
    {
        Build(); 
    }

    public void Build()
    {
        for (int i = 0; i <= 8; i++)
        {
            GameObject newCell = Instantiate(mCellPrefab, transform);
            mCells[i] = newCell.GetComponent<Cell>();
        }

    }
}
