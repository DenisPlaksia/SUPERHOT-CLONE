using UnityEngine;


/*Denis Plaksia*/
public class TimeManager : MonoBehaviour
{
    private float slowdownFactor = 0.005f;
    public void StopTime()
    {
        Time.timeScale = slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * .02f;
    }

    public void RunTime()
    {
        Time.timeScale = 1f;
        Time.fixedDeltaTime = 0.02f;
    }
}
