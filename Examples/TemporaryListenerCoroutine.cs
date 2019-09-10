class TemporaryListener : MonoBehaviour
{
    IEnumerator TemporaryListener()
    {
        bool emptyClip = true;
        while (emptyClip)
        {
            if (Input.GetButtonDown("Reload"))
            {
                ReloadWeapon();
                emptyClip = false;
            }
            yield return null;
        }
    }
}

/* 
 * Temporary Listeners are useful for scenarios where your application has a need to temporarily listen for input (player input, or other system input).
 * 
 * Examples: 
 * - Reloading
 * - Listening for changes to a queue
 * - Temporary user input like "Press Start to continue..."
 * - Nested input actions
 * /
