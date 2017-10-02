using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {
    private float timer;
    public Text text;
    public Text fin;
    private bool end;
    // Use this for initialization
    void Start () {
        timer = 5;
        text.text = "5";
        end = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (end)
            return;
        timer -= Time.deltaTime;
        int round = Mathf.RoundToInt(timer);
        text.text = round.ToString();
        if (round <= 0)
        {
            foreach (var flower in FindObjectsOfType<Flower>())
            {
                flower.GetComponent<CircleCollider2D>().enabled = false;
                flower.GetComponent<Flower>().enabled = false;
            }
            end = true;
            fin.text = "FIN!!!";
        }
    }

    public bool GetEnd()
    {
        return end;
    }
}
