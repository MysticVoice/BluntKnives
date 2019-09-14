using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureAnimator : MonoBehaviour
{
    public float framerate;
    public Texture2D startTexture;
    public RenderTexture target;
    public Texture2D[] textures;
    private int currentFrame = 0;
    private float timer = 0;
    private float timeToWait;
    // Start is called before the first frame update
    void Start()
    {
        timeToWait = 1f / framerate;
        Graphics.Blit(startTexture, target);
    }
    
    void OnEnable()
    {
        timeToWait = 1f / framerate;
        Graphics.Blit(startTexture, target);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= Time.time)
        {
            if (currentFrame < textures.Length)
            {
                Graphics.Blit(textures[currentFrame], target);
                currentFrame++;
            }
            else
            {
                currentFrame = 0;
                Graphics.Blit(textures[currentFrame], target);
                currentFrame++;
            }
            timer = Time.time + timeToWait;
        }
    }
}
