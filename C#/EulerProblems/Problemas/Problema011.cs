
namespace EulerProblems.Problemas
{
    internal class Problema011
    {
        enum Direction
        {
            Horizontal = 1,
            Vertical = 20,
            ForwardDiag = 21,
            BackwardDiag = 19
        }

        private static int MultiplyAdjacent(int[] allValuesArray, int initialPosition, Direction dir)
        {
            int result = 1;
            for (int i = initialPosition; i < initialPosition + (int)dir * 4; i += (int)dir)
            {
                result *= allValuesArray[i];
            }
            return result;
        }

        private static bool HasRoom(int[] allValuesArray, int initialPosition, Direction dir)
        {
            Func<bool> horiz = () => 20 - initialPosition % 20 >= 4;
            Func<bool> vert = () => initialPosition + 4 * 20 <= allValuesArray.Length;
            Func<bool> revHoriz = () => initialPosition % 20 >= 4;
            switch (dir)
            {
                case Direction.Horizontal:
                    return horiz();
                case Direction.Vertical:
                    return vert();
                case Direction.ForwardDiag:
                    return horiz() && vert();
                case Direction.BackwardDiag:
                    return vert() && revHoriz();
                default:
                    break;
            }
            return false;
        }

        private static int[] GetArray(string arrayValues)
        {
            string[] stringNumbers = arrayValues.Split(new string[] { "\r\n", " " }, StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[stringNumbers.Length];
            for (int i = 0; i < stringNumbers.Length; i++)
            {
                array[i] = int.Parse(stringNumbers[i]);
            }
            return array;
        }

        public static int GetBiggest(string stringArray)
        {
            int[] allValuesArray = GetArray(stringArray);
            var result = 0;
            for (int i = 0; i < allValuesArray.Length; i++)
            {
                foreach (var dir in Enum.GetValues(typeof(Direction)))
                {
                    if (HasRoom(allValuesArray, i, (Direction)dir))
                    {
                        var res = MultiplyAdjacent(allValuesArray, i, (Direction)dir);
                        if (res > result)
                        {
                            result = res;
                        }
                    }
                }
            }
            return result;
        }
    }
}
