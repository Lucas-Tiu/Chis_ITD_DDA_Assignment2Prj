/*
 * Author: Lucas Dominic Tiu
 * Date: 12/16/2022
 * Description: Allows background to continuously loop 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class backgroundLoop : MonoBehaviour
{
    [SerializeField] private RawImage _img; ///rawIMG ref
    [SerializeField] private float _x, _y; ///loop speed

    private void Update()
    {
        _img.uvRect = new Rect(_img.uvRect.position + new Vector2(_x, _y) * Time.deltaTime, _img.uvRect.size);
    }
}
