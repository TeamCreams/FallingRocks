using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAnimationEvents : InitBase
{
    public override bool Init()
    {
        if (base.Init() == false)
        {
            return false;
        }
        return true;
    }


    public void LoadingSuberunkerScene()
    {
        Managers.Scene.LoadScene(Define.EScene.SuberunkerScene);
    }
}
