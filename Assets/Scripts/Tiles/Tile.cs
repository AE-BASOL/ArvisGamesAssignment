using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color _baseColor, _offSetColor;
    [SerializeField] private SpriteRenderer _renderer; //we need to change offset tile color actually
    [SerializeField] private GameObject _highlight;
    public void Init(bool isOffset)
    {
        _renderer.color = isOffset ? _offSetColor : _baseColor;
    }

    void OnMouseEnter()
    {
        _highlight.SetActive(true);
    }

    void OnMouseExit()
    {
        _highlight.SetActive(false);
    }
}
