using System;
using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class ExecutionTester : MonoBehaviour
{
    private void Awake() => Log("Awake");
    private void OnEnable() => Log("OnEnable");

    private void Start()
    {
        Log("Start");
        StartCoroutine(TestCoroutine());
        TestAsync();
    }

    private void Update() => Log("Update");
    private void LateUpdate() => Log("LateUpdate");
    private void FixedUpdate() => Log("FixedUpdate");

    private IEnumerator TestCoroutine()
    {
        Log("Coroutine started (same frame as Start?)");

        yield return null;

        Log("Coroutine, next frame");

        yield return new WaitForFixedUpdate();

        Log("Coroutine after physics");
    }

    private async void TestAsync()
    {
        try
        {
            Log("Async started");
            await Task.Yield();
            Log("Async resumed next Update frame");
        }
        catch (Exception e)
        {
            Log(e.ToString());
        }
    }

    private static void Log(string msg)
    {
        Debug.Log($"{Time.frameCount}: {msg}");
    }
}