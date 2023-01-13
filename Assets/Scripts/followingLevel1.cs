internal class followingLevel
{
    static public int points = 0;
    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && points == 5)
        {
            SceneManager.LoadScene("Level4");
        }
    }
}