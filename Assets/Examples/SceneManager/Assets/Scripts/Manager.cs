using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour {
    public int scene;
    public GameObject yourButton;

    // Use this for initialization
    void Start () {
        if (yourButton != null)
        {
            Button btn = yourButton.GetComponent<Button>();
            btn.onClick.AddListener(OnMouseDown);
        }
    }
    void OnMouseDown()
    {
        loadScene();
    }

    private void loadScene() {
        Debug.Log(scene);
        SceneManager.LoadScene(scene);
        //SceneManager.SetActiveScene()
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
    }
}
