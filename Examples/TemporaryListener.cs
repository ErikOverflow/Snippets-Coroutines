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
