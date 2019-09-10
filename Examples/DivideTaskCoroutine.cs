class DivideTaskCoroutine : MonoBehaviour
{
    IEnumerator DivideComplexProcess(List<GameObject> listGo)
    {
        foreach(GameObject go in listGo)
        {
            Vector3 newPos = go.transform.position;
            newPos.x = Mathf.Pow(Mathf.sqrt(newPos.y + newPos.z), 2);
            go.transform = newPos.x;
            yield return null;
        }
        print("Done!");
    }
    
    IEnumator DivideComplexProcessTimed(Queue<GameObject> objQueue)
    {
        float timer = 0f;
        while(objQueue.Count > 0)
        {
            GameObject obj = objQueue.Dequeue();
            timer += Time.deltaTime;
            if(timer > 0.1f)
            {
                timer = 0f;
                yield return null;
            }
        }
    }
}

/* 
 * Tasks that often get divided are often large complex tasks that iterate over a large number of entities/objects.
 * 
 * This allows you to return control to the main thread mid-process, preventing allowing you to show a progress indicator and prevent the screen from freezing.
 * 
 * There are many ways to divide a process. 2 common ways are: 
 * - Return control after each object is processed in the loop
 * - Return control after a specified time has passed
 * 
 * Examples: 
 * - Generating a procedural world
 * - Simple image processing
 * - Loading a new scene
 * /
