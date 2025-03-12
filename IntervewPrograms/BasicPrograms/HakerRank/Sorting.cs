namespace BasicPrograms.HakerRank;
internal class Sorting
{
    public static T[] SortAscending<T>(T[] elements) where T : struct
    {
        T temp;
        if (typeof(T) == typeof(int))
        {

            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = i + 1; j < elements.Length; j++)
                {
                    if (Convert.ToInt32(elements[i]) > Convert.ToInt32(elements[j]))
                    {
                        temp = elements[j];
                        elements[j] = elements[i];
                        elements[i] = temp;
                    }
                }
            }

            return elements;
        }

        if (typeof(T) == typeof(string))
        {

            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = i + 1; j < elements.Length; j++)
                {
                    if (elements[i].ToString()?.CompareTo(elements[j].ToString()) > 0)
                    {
                        temp = elements[j];
                        elements[j] = elements[i];
                        elements[i] = temp;
                    }
                }
            }
            return elements;
        }

        throw new NotSupportedException();

    }
}
