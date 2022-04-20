using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int _width, _height;
    [SerializeField] private Tile _tilePreFab; //reference
    //[SerializeField] private Transform _cam;

    private Dictionary<Vector2, Tile> _tiles; // For storing and getting tiles


    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        _tiles = new Dictionary<Vector2, Tile>();

        for (int x = 0; x < _width; x++) //because X-AXIS
        {
            for (int y = 0; y < _height; y++)
            {
                var spawnedFile = Instantiate(_tilePreFab, new Vector3(x,y),Quaternion.identity);
                spawnedFile.name = $"Tile {x} {y}";

                var isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0); //checking x and y even or odd if so we want to color them differently
                spawnedFile.Init(isOffset);

                _tiles[new Vector2(x, y)] = spawnedFile; //For storing and getting tiles
            }
        }
    }

    public Tile GetTileAtPosition(Vector2 pos) //if you change something in Tile it keeps it, if not converts to null
    {
        if (_tiles.TryGetValue(pos, out var tile))
        {
            return tile;
        }

        return null;
    }
}
