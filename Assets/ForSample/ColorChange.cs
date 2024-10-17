using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    public Image image;

    public void ChangeColor()
    {
        image.color = Random.ColorHSV();
    }
}
