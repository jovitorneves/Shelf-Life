using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOffSet : MonoBehaviour
{
    private Material currentMaterial;
    public float speed;
    private float offSet;

    // Start is called before the first frame update
    void Start()
    {

        currentMaterial = GetComponent<Renderer>().material;

    }

    // Update is called once per frame
    void Update()
    {

        offSet += 0.001f;
        currentMaterial.SetTextureOffset ("Sprites_default", new Vector2 (offSet*speed,0));
    }
}
