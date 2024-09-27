namespace StatSnail
{
    internal class Snail
    {
        public int plife = 50;       // Point of life
        public int x = 0;           // Position x
        public int y;               // Position y
        public string alive = "_@_ö";    // Snail alive
        public string dead = "____";     // Snail dead
        public string name;


        // Constructor
        public Snail(int y, string name)
        {
            this.y = y;
        }
        // Method to move the snail
        public void Move()
        {
            x++;
            plife--;
        }
    }
}
