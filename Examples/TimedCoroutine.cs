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
        //Load a new scene
        //Player respawn timer
        //Close a door after x seconds
        //reload delay
    }
}
