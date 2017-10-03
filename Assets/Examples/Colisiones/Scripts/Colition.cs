using UnityEngine;

public class Colition : MonoBehaviour {

    private float _speed;
    private float _movementX = 4;
    private float _movementY = 3;
    // Use this for initialization
    void Start()
    {
        _movementX = 4;
        _movementY = 3;
        _speed = Random.Range(3, 7);//Seteo la velocidad con un random.
    }

    // Update is called once per frame
    void Update()
    {
        // Obtengo que tecla esta presionando.
        //gameObject es el componente principal al que esta adherido el script, transform es el cuerpo del componente, position la posicion en escena del componente.
        //Vector3 es un desplazamiento en una direccion con eje x, y, z.
        Vector3 position = gameObject.transform.position;
        if (Input.GetKey(KeyCode.A))
        {
            //Movimiento a la izquierda.
            gameObject.transform.position -= new Vector3(_movementX, 0, 0) * _speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            //Movimiento a la derecha.
            gameObject.transform.position += new Vector3(_movementX, 0, 0) * _speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            //Movimiento a la arriba.
            gameObject.transform.position += new Vector3(0, _movementY, 0) * _speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            //Movimiento a la abajo.
            gameObject.transform.position -= new Vector3(0, _movementY, 0) * _speed * Time.deltaTime;
        }
    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log(collision);
    //}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
    }
}
