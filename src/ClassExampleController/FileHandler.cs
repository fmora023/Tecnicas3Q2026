using ClassExampleController.Abstractions;

namespace ClassExampleController
{
    /// <summary>
    /// Implementation for <see cref="IDataHandler{T}"/> that handles data operations using files.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="ClassExampleController.Abstractions.IDataHandler&lt;T&gt;" />
    public class FileHandler<T> : IDataHandler<T>
    {
        /// <summary>
        /// Loads the data.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <returns>
        /// the list with the elements loaded from the file.
        /// </returns>
        public List<T> LoadData(string filename)
        {
            if (string.IsNullOrEmpty(filename) || !File.Exists(filename))
            {
                return null;
            }

            var data = new List<T>();
            var lines = File.ReadAllLines(filename);

            for (var i = 1; i< lines.Length; i++)
            {
                var lineElements = lines[i].Split(',');
                var newElement = Activator.CreateInstance(typeof(T), lineElements);
                data.Add((T)newElement);
            }

            return data;
        }

        /// <summary>
        /// Saves the data.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <param name="data">The data.</param>
        /// <returns>
        /// true if succeded, otherwise false.
        /// </returns>
        public bool SaveData(string filename, List<T> data)
        {
            if (string.IsNullOrEmpty(filename) || data == null || data.Count == 0)
            {
                return false;
            }

            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            foreach(var element in data)
            {
                File.AppendAllText(filename, element?.ToString() + Environment.NewLine);
            }

            return true;
        }
    }
}
