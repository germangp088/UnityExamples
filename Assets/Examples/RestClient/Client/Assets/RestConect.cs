using UnityEngine;
using UnityEngine.UI;

public class RestConect : MonoBehaviour
{
    public RESTFactory restFactory;
    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //restFactory.GET("http://localhost:50306/api/values/", GetResult);
        restFactory.GET("http://localhost:50306/api/values/5", GetResult);
    }

    void GetResult()
    {
        Debug.Log(restFactory.Results);
    }
}
