using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingDescription : MonoBehaviour
{
    [SerializeField] private string artistName;   // nom artiste
    [SerializeField] private string artWorkName; // nom oeuvre (image)
    [SerializeField] private string description; // descriptif oeuvre 

    PaintingDescription[] artWorkArray = new PaintingDescription[10];
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
