using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class Paralax : MonoBehaviour
{
    [SerializeField] private float _speed;
    private RawImage _image;
    private float _imagePosistionX;

    private void Start()
    {
        _image = GetComponent<RawImage>();
        _imagePosistionX = _image.uvRect.x;
    }

    private void Update()
    {
        _imagePosistionX += _speed * Time.deltaTime;

        if (_imagePosistionX > 1)
            _imagePosistionX = 0;

        _image.uvRect = new Rect(_imagePosistionX, 0, _image.uvRect.width, _image.uvRect.height);
    }
}
