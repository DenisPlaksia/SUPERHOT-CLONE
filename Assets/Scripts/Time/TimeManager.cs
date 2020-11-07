using UnityEngine;


/*Denis Plaksia*/
public class TimeManager : MonoBehaviour
{
    private float slowdownFactor = 0.005f;
    public void StopTime() => Time.timeScale = slowdownFactor;

    public void RunTime() => Time.timeScale = 1f;
}
