namespace SnakeClean
{
    public class Snake{
        public static int score = 0;
        public static bool ate = false;
        public static bool isPaused = true;

        public static int[] color = new int[3];

        public static void alteraCor(int x, int y, int z){
            color[0] = x;
            color[1] = y;
            color[2] = z;
        }
    }
    
}
