using UnityEngine;

public class Foco : MonoBehaviour {
    private bool prendida;
    public Sprite on;
    public Sprite off;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        prendida = true;
        spriteRenderer = GetComponent<SpriteRenderer>(); 
        if (spriteRenderer.sprite == null)
            spriteRenderer.sprite = on;
    }


    private void OnMouseDown()
    {
        if (prendida)
        {
            prendida = false;
            spriteRenderer.sprite = off;
        }
    }
}
