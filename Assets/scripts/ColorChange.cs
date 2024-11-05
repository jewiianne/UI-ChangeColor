using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    public Renderer hairObjectRenderer;
    public Texture[] hairTextures;
    private int hairCurrentTextureIndex = 0;
    
    public Button hairUpButton;
    public Button hairDownButton;

    void Start()
    {
        if (hairObjectRenderer != null && hairTextures.Length > 0)
        {
            hairObjectRenderer.material.mainTexture = hairTextures[hairCurrentTextureIndex];
        }

        hairUpButton.onClick.AddListener(ChangeTextureUp);
        hairDownButton.onClick.AddListener(ChangeTextureDown);    
    }

    void ChangeTextureUp ()
    {
        hairCurrentTextureIndex--;

        if (hairCurrentTextureIndex < 0)
        {
            hairCurrentTextureIndex = hairTextures.Length - 1;
        }
        UpdateTexture();
    }

    void ChangeTextureDown ()
    {
        hairCurrentTextureIndex++;

        if (hairCurrentTextureIndex >= hairTextures.Length)
        {
            hairCurrentTextureIndex = 0;
        }
        UpdateTexture();
    }

    void UpdateTexture ()
    {
        if (hairObjectRenderer != null && hairTextures.Length > 0)
        {
            hairObjectRenderer.material.mainTexture = hairTextures[hairCurrentTextureIndex];
        }
    }
}
