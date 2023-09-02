using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeScene
{
    MainMenu,
    Shop,
    Settings
}

[System.Serializable]
public class SceneObjType
{
    public TypeScene type;
    public GameObject obj;
    public MenuSceneBase sceneBase;

    public void ShowScene()
    {
        obj.SetActive(true);
        sceneBase.Hide();
        sceneBase.Show();
    }

    public void CloseScene()
    {
        obj.SetActive(false);
    }
}

public class SceneManager : MonoBehaviour
{
    public TypeScene typeStart;
    public List<SceneObjType> sceneObjTypes;

    private void Start()
    {
        ToChangeScene(typeStart);
    }

    public void ToChangeScene(TypeScene type)
    {
        sceneObjTypes.ForEach(i => i.CloseScene());
        foreach(SceneObjType sceneObj in sceneObjTypes)
        {
            if (sceneObj.type == type)
            {
                sceneObj.ShowScene();
                break;
            }
        }
    }
}