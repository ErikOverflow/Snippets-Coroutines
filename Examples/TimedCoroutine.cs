class TimedCoroutine : MonoBehaviour
{
    IEnumerator CountdownToAction()
    {
        int countdown = 5;
        while(countdown >= 0)
        {
            print(countdown--);
            yield return new WaitForSeconds(1);
        }
        //Perform action here
    }
}

/* 
 * Examples: 
 * - Loading a new scene or level
 * - Close a door/object
 * - Add a reload delay to a weapon
 * - Respawn timer
 * /
