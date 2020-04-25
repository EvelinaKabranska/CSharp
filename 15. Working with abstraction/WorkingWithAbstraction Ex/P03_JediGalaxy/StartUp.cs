namespace P03_JediGalaxy
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            var matrix = GetMatrix();

            long collectedStars = 0;
            collectedStars = CollectStars(matrix);
            Console.WriteLine(collectedStars);
        }
        private static long CollectStars(long[,] matrixx)
        {
           long collectedStars = 0;
            var input = Console.ReadLine();

            while (input != "Let the Force be with you")
            {
                var ivoPossition = input.Split().Select(long.Parse).ToArray();
                var evilPossition = Console.ReadLine().Split().Select(long.Parse).ToArray();

                EvilMove(matrixx, evilPossition);
                collectedStars = IvoMove(matrixx, ivoPossition);

                input = Console.ReadLine();
            }
            return collectedStars;
        }
        private static void EvilMove(long[,] matrix, long[] evilPossition)
        {
            var xEvil = evilPossition[0];
            var yEvil = evilPossition[1];

            while (xEvil >= 0 && yEvil >= 0)
            {
                if (IsInMatrix(matrix,xEvil,yEvil))
                {
                    matrix[xEvil, yEvil] = 0;
                }
                xEvil--;
                yEvil--;
            }
        }
        private static long IvoMove(long[,]matrix,long[]ivoPossition)
        {
            long collectedStars = 0;
            var xIvo = ivoPossition[0];
            var yIvo = ivoPossition[1];

            while (xIvo >= 0 && yIvo < matrix.GetLength(1))
            {
                if (IsInMatrix(matrix, xIvo, yIvo))
                {
                    collectedStars += matrix[xIvo, yIvo];
                }
                xIvo--;
                yIvo++;
            }
            return collectedStars;

        }

        private static long[,] GetMatrix()
        {
            var dimestions = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var x = dimestions[0];
            var y = dimestions[1];

            var matrix = new long[x, y];

            var value = 0;
            for (long i = 0; i < x; i++)
            {
                for (long j = 0; j < y; j++)
                {
                    matrix[i, j] = value++;
                }
            }

            return matrix;
        }
        private static bool IsInMatrix(long[,] matrix, long position1,long position2)
        {
            return position1 >= 0 && position1 < matrix.GetLength(0) && position2 >= 0 && position2 < matrix.GetLength(1);
            
        }
    }
}
