using UnityEngine;


public static class Utilities
{
    public static Vector2 GetRandomPosition()
    {
        var cam = Camera.main;
        float height = 2f * cam.orthographicSize;
        float width = height * cam.aspect;

        float x = Random.Range(-width / 2, width / 2);
        float y = Random.Range(-height / 2, height / 2);

        return new Vector2(cam.transform.position.x + x, cam.transform.position.y + y);
    }
}