using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TitleScreenScript : MonoBehaviour
{
    public AudioSource backgroundMusic;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.backgroundMusic);

    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
            SceneManager.LoadScene("HowtoPlay", LoadSceneMode.Single);
        }
    }
}
