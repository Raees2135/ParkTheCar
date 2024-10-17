using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChangeScript : MonoBehaviour
{
    public Image image;

    public void ChangeImageColor()
    {
        image.color = Random.ColorHSV();
    }
}
