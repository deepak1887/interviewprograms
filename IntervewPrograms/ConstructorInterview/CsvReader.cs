namespace ConstructorInterview
{
    public class CsvReader<T> where T : class
    {
        private readonly string _filePath;
        public CsvReader(string filePath)
        {
            _filePath = filePath;
        }

        //public List<T> ReadFirstnUsers(int nUsers)
        //{
        //List<T> savedUserInfos = new List<T>();
        //var userInfos = File.ReadAllLines(this._filePath)
        //                    .Skip(1)
        //                    .Take(nUsers)
        //                    .Select(x => ReadUserFromCsv(x))
        //                    .ToList();
        //using (var reader = new StreamReader(this._filePath))
        //{
        //    reader.ReadLine();
        //    while (!reader.EndOfStream)
        //    {                   
        //        savedUserInfos.Add(ReadUserFromCsv(reader.ReadLine()));
        //    }
        //for(int i=0; i<nUsers; i++)
        //{
        //    string csvLine = reader.ReadLine();
        //    savedUserInfos[i] = ReadUserFromCsv(csvLine);
        //}
        //}
        //    return userInfos;
        //}

        //private T ReadUserFromCsv(string csvLine)
        //{
        //    string[] parts = csvLine.Split(',');
        //    var savedInfo = Activator.CreateInstance(typeof(T));


        //    return savedInfo;
        //}
    }
}
