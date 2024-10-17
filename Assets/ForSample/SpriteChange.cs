using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChange : MonoBehaviour
{
    public Image image;
    public Sprite sprite1;
    public Sprite sprite2;

    public void ChangeSprite()
    {
        if (image.sprite == null || image.sprite == sprite2)
        {
            image.sprite = sprite1;
        }
        else
        {
            image.sprite = sprite2;
        }

    }


}
