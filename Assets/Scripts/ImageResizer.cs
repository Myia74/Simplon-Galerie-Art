using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageResizer : MonoBehaviour
{

    [SerializeField] private SpriteRenderer spriteRenderer;
    public Image targetImage;
    public string imageName;

    // Start is called before the first frame update
    void Start()
    {

        // chargement image par chemin suivant 
        string imagePath = "Assets/Images"; 
        Texture2D texture = LoadImage(imagePath);

        // Redimensionner image pour adaptation taille du cadre
        Vector2 frameSize = spriteRenderer.size;
        texture = ResizeImage(texture, frameSize);

        // Appliquer la texture redimensionnee au sprite renderer
        spriteRenderer.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);

    }

    private Texture2D LoadImage(string imagePath)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Texture2D ResizeImage(Texture2D texture, Vector2 targetSize)
    {
        // Calculer les proportions pour redimensionner correctement l'image
        float aspectRatio = (float)texture.width / texture.height;
        int targetWidth = (int)targetSize.x;
        int targetHeight = (int)(targetSize.x / aspectRatio);

        // Vérifier si la hauteur redimensionnée dépasse la taille cible
        if (targetHeight > targetSize.y)
        {
            targetHeight = (int)targetSize.y;
            targetWidth = (int)(targetSize.y * aspectRatio);
        }

        // Redimensionner la texture
        Texture2D resizedTexture = new Texture2D(targetWidth, targetHeight, texture.format, false);
        resizedTexture.filterMode = FilterMode.Bilinear;
        resizedTexture.SetPixels(texture.GetPixels(0, 0, targetWidth, targetHeight));
        resizedTexture.Apply();

        return resizedTexture;
    }

}