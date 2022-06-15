using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class SaveLoad
{
    private static int currentScene;
    private static float x;
    private static float y;
    private static float z;
    public static Vector3 pos;
    public static void  Save(Vector3 pos)
    {
        
        // currentScene = EditorSceneManager.GetActiveScene().buildIndex;
        
        
        
        x = pos.x;
        y = pos.y;
        z = pos.z;
        
        PlayerPrefs.SetFloat("playerX", x);
        PlayerPrefs.SetFloat("playerY", y);
        PlayerPrefs.SetFloat("playerZ", z);
        PlayerPrefs.SetInt("currentScene", currentScene);
        
    }

    public static void Load()
    {
        // SceneManager.LoadScene(currentScene);
        Vector3 pos = new Vector3(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY"), PlayerPrefs.GetFloat("playerZ"));
        SaveLoad.pos = pos;
    }
}
