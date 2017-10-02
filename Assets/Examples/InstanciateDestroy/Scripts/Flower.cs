using UnityEngine;

public class Flower : MonoBehaviour {

    private SpriteRenderer spriteRenderer;
    public Sprite blueFlower;
    public Sprite redFlower;

    // Use this for initialization
    void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
            spriteRenderer.sprite = blueFlower;
    }

    /// <summary>
    /// Cuando se hace un Destroy es recomendado destruir el componente principal gameObject que referencia
    /// al prefab para liberar la memoria.
    /// </summary>
    void OnMouseDown()
    {
        Destroy(gameObject);
    }

    /// <summary>
    /// Evento que se dispara cuando el mouse sale del componente.
    /// </summary>
    void OnMouseExit()
    {
        spriteRenderer.sprite = blueFlower;
    }

    /// <summary>
    /// Evento que se dispara cuando el mouse ingresa al componente.
    /// </summary>
    void OnMouseEnter()
    {
        spriteRenderer.sprite = redFlower;
    }
}
