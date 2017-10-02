using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour {

    public string animal;//Al ser una variable publica se puede inicializar desde la vista de diseño.
    private Text texto;
    private GameObject g;

    // Se ejecuta al instanciar el componente en memoria.
    private void Awake()
    {
        
    }

    // Inicializa variables y objetos.
    void Start () {
        texto = FindObjectOfType<Text>();//Obtiene el Text de la escena;
        g = GameObject.FindWithTag("Texto");//Se puede acceder por tag de esta manera
    }

    // Se ejecuta en cada frame de la escena, todos los scripts ejecutan update sobre el frame.
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.LogWarning("Tocaste el frame");//Se va a imprimir 3 veces porque hay 3 objetos activos con este update.
        }
    }

    private void OnMouseDown()
    {
        texto.text = animal;//Cambia el texto segun el string animal.
        //Modo de loguear en consola.
        Debug.Log(g.GetComponent<Text>().text);//Los objetos texto y g comparten la misma referencia de memoria, cuando se actualiza uno el otro tambien lo hace.
    }
}
