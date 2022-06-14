using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Controls : MonoBehaviour
{

    public PlayableDirector playableDirector;
    public PlayableAsset[] playables;

    private int index = 0;

    // Start is called before the first frame update
    void Awake()
    {
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playableDirector.state == PlayState.Paused)
        {
            if (index > 3) {
                index = 0;
            }

            playableDirector.playableAsset = playables[index];
            playableDirector.Play();
            index += 1;
        }

    }
}
