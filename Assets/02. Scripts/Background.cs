using UnityEngine;

public class Background : MonoBehaviour
{
    public float scrollspeed = 0.2f;
    public Material bgMaterial;

    void Start()
    {
    }

    void Update()
    {
        Vector2 dir = Vector2.up;
        bgMaterial.mainTextureOffset += dir * scrollspeed * Time.deltaTime;
    }
}
