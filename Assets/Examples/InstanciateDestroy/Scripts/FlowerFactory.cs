using UnityEngine;

public class FlowerFactory : MonoBehaviour
{
    public Flower flower;
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(flower, new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), -1), Quaternion.identity);
        }
    }
}
