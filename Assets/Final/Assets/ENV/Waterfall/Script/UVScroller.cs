using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UVScroller : MonoBehaviour
{

    public int targetMaterialSlot=0;
    public float speedY = 0.5f;
    float speedX = 0.0f;
    private float timeWentX = 0;
    private float timeWentY = 0;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        timeWentY += Time.deltaTime * speedY;
        timeWentX += Time.deltaTime * speedX;
        rend = GetComponent< Renderer > ();
        rend.materials[targetMaterialSlot].SetTextureOffset("_MainTex", new Vector2(timeWentX, timeWentY));
    }
    private void OnEnable()
    {
        rend = GetComponent<Renderer>();
        rend.materials[targetMaterialSlot].SetTextureOffset("_MainTex", new Vector2(0, 0));
        timeWentX = 0;
        timeWentY = 0;

    }



}
