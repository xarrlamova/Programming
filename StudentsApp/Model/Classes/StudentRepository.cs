using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;
using System.Reflection.Metadata.Ecma335;

namespace StudentsApp.Model.Classes
{
    /// <summary>
    /// Класс для сериализации и десериализации данных.
    /// </summary>
    public static class StudentRepository
    {
        /// <summary>
        /// Путь к директории.
        /// </summary>
        private static readonly string PathDirectory = 
            $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/StudentsApp";

        /// <summary>
        /// Путь к файлу.
        /// </summary>
        private static readonly string PathFile = $"{PathDirectory}/students.json";

        /// <summary>
        /// Метод для получения id последнего добавленного пользователя.
        /// </summary>
        /// <returns>Возвращает ID(int).</returns>
        public static int GetId()
        {
            var dto = JsonConvert.DeserializeObject<Dto>(File.ReadAllText(PathFile));
            return dto.ID;
        }

        /// <summary>
        /// Метод для получения всех студентов.
        /// </summary>
        /// <returns>Возвращает список студентов.</returns>
        public static List<Student> Load()
        {
            try
            {
                var dto = JsonConvert.DeserializeObject<Dto>(File.ReadAllText(PathFile));
                return dto.StudentsCollection;
            }
            catch (DirectoryNotFoundException)
            {
                var dataString = CreateDto();
                Directory.CreateDirectory(PathDirectory);
                CreateNewFile<Dto>();
                File.WriteAllText(PathFile, dataString);
                return new List<Student>();

            }
            catch (FileNotFoundException)
            {
                var dataString = CreateDto();
                CreateNewFile<Dto>();
                File.WriteAllText(PathFile, dataString);
                return new List<Student>();

            }
            catch (JsonSerializationException)
            {
                var dataString = CreateDto();
                CreateNewFile<Dto>();
                File.WriteAllText(PathFile, dataString);
                return new List<Student>();
            }
        }

        /// <summary>
        /// Сохраняет информацию.
        /// </summary>
        /// <param name="students">Список студентов.</param>
        /// <param name="id"">ID последнего добавленного студента.</param>
        public static void Save(List<Student> students, int id)
        {
            try
            {
                var dto = new Dto();
                dto.StudentsCollection = new List<Student>();
                dto.StudentsCollection = students;
                dto.ID = id;
                File.WriteAllText(PathFile, JsonConvert.SerializeObject(dto));
            }
            catch (DirectoryNotFoundException)
            {
                var dataString = CreateDto();
                Directory.CreateDirectory(PathDirectory);
                CreateNewFile<Dto>();
                File.WriteAllText(PathFile, dataString);
            }
            catch (FileNotFoundException)
            {
                var dataString = CreateDto();
                CreateNewFile<Dto>();
                File.WriteAllText(PathFile, dataString);
            }
            
        }

        
        /// <summary>
        /// Создает файл.
        /// </summary>
        /// <typeparam name="T">Тип файла.</typeparam>
        /// <param name="items">Содерижмое файла.</param>
        private static void CreateNewFile<T>(List<T> items = null)
        {
            using var fileStream = File.Create(PathFile);

            if(items != null)
            {
                File.WriteAllText(PathFile, JsonConvert.SerializeObject(items));
            }
        }

        /// <summary>
        /// Создает экземпляр класса Dto.
        /// </summary>
        /// <returns>Возвращает строку.</returns>
        private static string CreateDto()
        {
            var _dto = new Dto();
            _dto.ID = 100000;
            _dto.StudentsCollection = new List<Student>();
            var dataString = JsonConvert.SerializeObject(_dto);
            return dataString;
        }
    }
}
