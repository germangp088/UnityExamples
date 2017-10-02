using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audios : MonoBehaviour {

    public List<AudioClip> audios;
    private Button btn;
    // Use this for initialization
    void Start () {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(Task);

    }

    void Task()
    {
        AudioSource reproductor = GetComponent<AudioSource>();
        reproductor.PlayOneShot(audios[Random.Range(0, audios.Count)]);
    }
}
