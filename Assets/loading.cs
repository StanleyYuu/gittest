using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loading : MonoBehaviour
{
    AsyncOperation async;

    void Start()
    {
        //在这里开启一个异步任务，
        //进入loadScene方法。
        StartCoroutine(loadScene());
    }

    IEnumerator loadScene()
    {
        //异步读取场景。
        //Globe.loadName 就是A场景中需要读取的C场景名称。
        async = Application.LoadLevelAsync(Globe.scencename);

        //读取完毕后返回， 系统会自动进入C场景
        yield return async;

    }

}